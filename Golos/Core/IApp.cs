namespace Core
{
    public interface IApp
    {
        string[] Argument { get; set; }
        void Respond();
        void Do();
    }
}