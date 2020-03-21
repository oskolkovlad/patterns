namespace FabricMethod
{
    public interface IMessanger
    {
        string UserName { get; }
        string Password { get; }
        bool Connected { get; }

        IMessage CreateMessage(string text, string source, string target);

        bool Authorize();
    }
}