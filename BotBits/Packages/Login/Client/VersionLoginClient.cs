using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using PlayerIOClient;

namespace BotBits
{
    public class VersionLoginClient : ILoginClient
    {
        private readonly LoginClient _loginClient;
        private const string EverybodyEdits = "Everybodyedits";
        private const string Beta = "Beta";

        internal VersionLoginClient(LoginClient loginClient, int version)
        {
            this._loginClient = loginClient;
            this.Version = version;
        }

        public int Version { get; }

        public Task<LobbyItem[]> GetLobbyAsync()
        {
            var normals = this._loginClient.Client.GetLobbyRoomsAsync(this, EverybodyEdits + this.Version);
            var betas = this._loginClient.Client.GetLobbyRoomsAsync(this, Beta + this.Version);
            return Task.Factory
                .ContinueWhenAll(new[] { normals, betas }, items => items.SelectMany(i => i.Result).ToArray())
                .ToSafeTask();
        }

        public Task CreateOpenWorldAsync(string roomId, string name, CancellationToken ct)
        {
            if (!roomId.StartsWith("OW")) throw new ArgumentException("RoomId is not valid.", nameof(roomId));

            var roomData = new Dictionary<string, string> { { "name", name } };

            return this._loginClient.Client.Multiplayer
                .CreateJoinRoomAsync(roomId, EverybodyEdits + this.Version, true, roomData,
                    new Dictionary<string, string>())
                .Then(task => this._loginClient.InitConnection(roomId, this.Version, task.Result, ct))
                .ToSafeTask();
        }

        public Task CreateJoinRoomAsync(string roomId, CancellationToken ct)
        {
            var roomPrefix = roomId.StartsWith("BW", StringComparison.OrdinalIgnoreCase)
                ? Beta
                : EverybodyEdits;

            return this._loginClient.Client.Multiplayer
                .CreateJoinRoomAsync(roomId, roomPrefix + this.Version, true, null, null)
                .Then(task => this._loginClient.InitConnection(roomId, this.Version, task.Result, ct))
                .ToSafeTask();
        }

        public Task JoinRoomAsync(string roomId, CancellationToken ct)
        {
            return this._loginClient.JoinRoomAsync(roomId, ct);
        }
    }
}