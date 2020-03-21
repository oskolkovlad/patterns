namespace FabricMethod
{
    public interface IMessage
    {
        string Text { get; }
        string Source { get; }
        string Target { get; }

        void Send();
    }
}