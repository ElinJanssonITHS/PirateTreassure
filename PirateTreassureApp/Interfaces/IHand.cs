namespace PirateTreassureApp.Interfaces;
public enum Hands
{
    Left,
    Right
}

public interface IHand : IStorage
{
    Hands Hand { get; set; }
}
