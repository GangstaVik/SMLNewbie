// Classe per gli effetti (placeholder)
internal class Effect
{
    public string EffectName { get; set; }
    public double Power { get; set; }

    public Effect(string name, double power)
    {
        EffectName = name;
        Power = power;
    }
}