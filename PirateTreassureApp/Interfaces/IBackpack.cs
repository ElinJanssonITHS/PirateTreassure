namespace PirateTreassureApp.Interfaces;

public interface IBackpack : IStorage
{
    void Sort();
    void Position(IItem item);
}
