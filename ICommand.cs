namespace TVRemote
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}