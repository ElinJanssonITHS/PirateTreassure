namespace PirateTreassureApp.Interfaces;

public interface IStorage
{
    int Id { get; }
    int MaxSize { get; }
    int SquareSize { get; }
    void RemoveItem(IItem item);
    void Add(IItem item);
}
