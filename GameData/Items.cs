namespace MyFirstGame.GameData;
internal class Items
{
    // Lista di tutti gli item disponibili
    public static List<Item> AllItems = new List<Item>();

    // Metodo per aggiungere un item alla lista disponibile
    public static void CreateItem(int id, string name, double rarity, string description)
    {
        var newItem = new Item(id, name, rarity, description);
        AllItems.Add(newItem);
    }

    // Metodo per assegnare effetti all'item in base all'id
    public static void AssignEffects(int itemId, List<Effect> effects)
    {
        var item = AllItems.Find(i => i.Id == itemId);
        if (item != null)
        {
            item.Effects.AddRange(effects);
            Console.WriteLine($"Effetti assegnati all'item '{item.Name}'.");
        }
        else
        {
            Console.WriteLine("Item non trovato.");
        }
    }

    // Metodo di esempio per testare
    public static void Test()
    {
        // Creiamo un item
        CreateItem(1, "Spada di Fuoco", 0.8, "Una spada infuocata.");

        // Assegniamo effetti
        AssignEffects(1, new List<Effect> {
                new Effect("Danno elevato", 50),
                new Effect("Raggio di fuoco", 20)
            });

        // Creiamo il player
        Player player = new Player();

        // Troviamo l'item e lo aggiungiamo all'inventario
        var itemToAdd = AllItems.Find(i => i.Id == 1);
        if (itemToAdd != null)
        {
            player.AddItem(itemToAdd);
            // Usare l'item
            player.UseItem(itemToAdd);
        }
    }
}
