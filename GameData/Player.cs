internal class Player
{
    public List<Item> Inventory { get; private set; }

    public Player()
    {
        Stats = new PlayerStats();
        Inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine($"Item '{item.Name}' aggiunto all'inventario.");
    }

    public void UseItem(Item item)
    {
        Console.WriteLine($"Usando l'item: {item.Name}");
        foreach (var effect in item.Effects)
        {
            Console.WriteLine($"Applicando effetto: {effect.EffectName} con potenza {effect.Power}");
            // Qui puoi applicare effetti al player o al mob
        }
    }
}