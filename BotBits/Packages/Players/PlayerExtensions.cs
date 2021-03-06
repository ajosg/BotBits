﻿using JetBrains.Annotations;

namespace BotBits
{
    public static class PlayerExtensions
    {
        public static void Kick(this Player player)
        {
            Chat.Of(player.BotBits).Kick(player.Username);
        }

        public static void Kick(this Player player, string reason)
        {
            Chat.Of(player.BotBits).Kick(player.Username, reason);
        }

        [StringFormatMethod("args")]
        public static void Kick(this Player player, string reason, params object[] args)
        {
            Chat.Of(player.BotBits).Kick(player.Username, reason, args);
        }

        public static void GiveCrown(this Player player)
        {
            Chat.Of(player.BotBits).GiveCrown(player.Username);
        }

        public static void GiveEdit(this Player player)
        {
            Chat.Of(player.BotBits).GiveEdit(player.Username);
        }

        public static void RemoveEdit(this Player player)
        {
            Chat.Of(player.BotBits).RemoveEdit(player.Username);
        }

        public static void GiveGod(this Player player)
        {
            Chat.Of(player.BotBits).GiveGod(player.Username);
        }

        public static void RemoveGod(this Player player)
        {
            Chat.Of(player.BotBits).RemoveGod(player.Username);
        }

        public static void Kill(this Player player)
        {
            Chat.Of(player.BotBits).Kill(player.Username);
        }

        public static void Mute(this Player player)
        {
            Chat.Of(player.BotBits).Mute(player.Username);
        }

        public static void Unmute(this Player player)
        {
            Chat.Of(player.BotBits).Unmute(player.Username);
        }

        public static void PrivateMessage(this Player player, string message)
        {
            Chat.Of(player.BotBits).PrivateMessage(player, message);
        }

        [StringFormatMethod("args")]
        public static void PrivateMessage(this Player player, string message, params object[] args)
        {
            Chat.Of(player.BotBits).PrivateMessage(player.Username, message, args);
        }

        public static void ReportAbuse(this Player player, string reason)
        {
            Chat.Of(player.BotBits).ReportAbuse(player.Username, reason);
        }

        [StringFormatMethod("args")]
        public static void ReportAbuse(this Player player, string reason, params object[] args)
        {
            Chat.Of(player.BotBits).ReportAbuse(player.Username, reason, args);
        }

        public static void Teleport(this Player player)
        {
            Chat.Of(player.BotBits).Teleport(player.Username);
        }

        public static void Teleport(this Player player, int x, int y)
        {
            Chat.Of(player.BotBits).Teleport(player.Username, x, y);
        }

        public static void Teleport(this Player player, Point point)
        {
            Chat.Of(player.BotBits).Teleport(player.Username, point);
        }

        public static void TeleportExact(this Player player, int x, int y)
        {
            Chat.Of(player.BotBits).TeleportExact(player.Username, x, y);
        }

        public static void TeleportExact(this Player player, Point point)
        {
            Chat.Of(player.BotBits).TeleportExact(player.Username, point);
        }

        public static void ForceFly(this Player player, bool flying)
        {
            Chat.Of(player.BotBits).ForceFly(player.Username, flying);
        }

        public static void GiveEffect(this Player player, Effect effect)
        {
            Chat.Of(player.BotBits).GiveEffect(player.Username, effect);
        }

        public static void GiveEffect(this Player player, Effect effect, int value)
        {
            Chat.Of(player.BotBits).GiveEffect(player.Username, effect, value);
        }

        public static void RemoveEffect(this Player player, Effect effect)
        {
            Chat.Of(player.BotBits).RemoveEffect(player.Username, effect);
        }

        public static void ClearEffects(this Player player)
        {
            Chat.Of(player.BotBits).ClearEffects(player.Username);
        }

        public static void SetTeam(this Player player, Team team)
        {
            Chat.Of(player.BotBits).SetTeam(player.Username, team);
        }

        public static void Reset(this Player player)
        {
            Chat.Of(player.BotBits).Reset(player.Username);
        }

        public static void Respawn(this Player player)
        {
            Chat.Of(player.BotBits).Respawn(player.Username);
        }

        public static void Forgive(this Player player)
        {
            Chat.Of(player.BotBits).Forgive(player.Username);
        }

        public static void SetGravity(this Player player, Gravity gravity)
        {
            Chat.Of(player.BotBits).SetGravity(player.Username, gravity);
        }
    }
}