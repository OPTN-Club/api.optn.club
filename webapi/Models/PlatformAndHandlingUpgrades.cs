namespace webapi.Models;

public class PlatformAndHandlingUpgrades
{
    public Upgrade Brakes { get; set; }

    public FullUpgrade Springs { get; set; }
    public Upgrade FrontArb { get; set; }
    public Upgrade RearArb { get; set; }
    public Upgrade ChassisReinforcement { get; set; }
    public Upgrade WeightReduction { get; set; }


}
