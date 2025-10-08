public class PlayerStats
{
    // Stats principali
    public int Level { get; set; } = 1;
    public int Hp { get; set; } = 10;
    public int MaxHp { get; set; } = 10;
    public int Mp { get; set; } = 10;
    public int MaxMp { get; set; } = 10;
    public int Str { get; set; } = 10; // Attacco base / danno fisico
    public int Dex { get; set; } = 10; // Crit/Evasione
    public int Mag { get; set; } = 10; // Danno magico / mana
    public int Exp { get; set; } = 0;
    public int ExpToNextLevel { get; set; } = 20;

    // Stat speciali sbloccabili
    public int Luck { get; set; } = 0; // probabilità di ottenere item di alta rarità
    public int Ada { get; set; } = 0; // adattabilità temporanea
    public int Soul { get; set; } = 0; // scala tutte le stats permanentemente

    // Metodo per salire di livello
    public void LevelUp()
    {
        Level++;
        // Puoi definire qui come aumentano le stats quando sali di livello
        Hp = MaxHp += 5; // esempio: aumenta HP di 5
        Mp = MaxMp += 3; // esempio: aumenta MP di 3
        Str += 2;
        Dex += 2;
        Mag += 2;
        Console.WriteLine($"Livello aumentato a {Level}!");
    }

    // Metodo per aggiungere esperienza
    public void AddExp(int amount)
    {
        Exp += amount;
        if (Exp >= ExpToNextLevel)
        {
            Exp -= ExpToNextLevel;
            LevelUp();
            // Puoi aumentare ExpToNextLevel per rendere più difficile salire di livello
            ExpToNextLevel += 10; // esempio
        }
    }
}