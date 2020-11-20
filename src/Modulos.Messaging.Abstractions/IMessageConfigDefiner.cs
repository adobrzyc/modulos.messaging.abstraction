namespace Modulos.Messaging
{
    public interface IMessageConfigDefiner
    {
        ConfigOrder Order { get; }
        bool IsForThisMessage(IMessage message);
        void GetConfig(IMessage message, ref IMessageConfig config);
    }
}