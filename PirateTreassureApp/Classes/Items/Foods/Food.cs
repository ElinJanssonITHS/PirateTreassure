using PirateTreassureApp.Interfaces;

namespace PirateTreassureApp.Classes.Items.Foods
{
    public class Food : IItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
    }
}
