using PirateTreassureApp.Interfaces;

namespace PirateTreassureApp.Classes.Items.Weapons;

public class Weapon : IItem
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Size { get; set; }
    public int Durability { get; set; }
    public int BaseDamage { get; set; }

    public virtual double CalculateDamege(double strength)
    {

    }
}
