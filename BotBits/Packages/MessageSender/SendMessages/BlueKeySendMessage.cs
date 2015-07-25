using PlayerIOClient;

namespace BotBits.SendMessages
{
    /// <summary>
    ///     Class Press Blue Key Send Event
    /// </summary>
    public sealed class BlueKeySendMessage : RoomTokenSendMessage<BlueKeySendMessage>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public BlueKeySendMessage()
        {
        }

        public BlueKeySendMessage(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        ///     Gets the PlayerIO message representing the data in this <see cref="SendMessage{T}" />.
        /// </summary>
        /// <returns></returns>
        protected override Message GetMessage()
        {
            return Message.Create(this.RoomToken + "b", this.X, this.Y);
        }
    }
}