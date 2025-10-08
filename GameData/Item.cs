internal class Item
{
    public int Id;
    public string Name;
    public double Rarity;
    public string Description;
    public List<Effect> Effects; // effetti associati all'item

    public Item(int id, string name, double rarity, string description)
    {
        Id = id;
        Name = name;
        Rarity = rarity;
        Description = description;
        Effects = new List<Effect>();
    }
}