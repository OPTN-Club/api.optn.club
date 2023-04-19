namespace webapi.Models;

public class Upgrades
{
    public int Id { get; set; }
    public Upgrade Intake { get; set; }
    public Upgrade IntakeManifold { get; set; }
    public Upgrade Carburator { get; set; }
    public Upgrade FuelSystem { get; set; }
    public Upgrade Ignition { get; set; }
    public Upgrade Exhaust { get; set; }
    public Upgrade Camshaft { get; set; }
    public Upgrade Valves { get; set; }
    public Upgrade Displacement { get; set; }
    public Upgrade Pistons { get; set; }
    public TurboUpgrade Turbo { get; set; }
    public TurboUpgrade TwinTurbo { get; set; }
    public Upgrade Supercharger { get; set; }
    public Upgrade CentrifugalSupercharger { get; set; }
    public Upgrade Intercooler { get; set; }
    public Upgrade OilCooling { get; set; }
    public Upgrade Flywheel { get; set; }
    public RestrictorUpgrade RestrictorPlate { get; set; }

    // Platforma nd Handling
    public Upgrade Brakes { get; set; }
    public FullUpgrade Springs { get; set; }
    public Upgrade FrontArb { get; set; }
    public Upgrade RearArb { get; set; }
    public Upgrade ChassisReinforcement { get; set; }
    public Upgrade WeightReduction { get; set; }

    // Drivetrain
    public Upgrade Clutch { get; set; }
    public TransmissionUpgrade Transmission { get; set; }
    public Upgrade Driveline { get; set; }
    public FullUpgrade Differential { get; set; }

    // Tires and Rims
    public TireCompound Compound { get; set; }
    public FrontAndRearSettings Width { get; set; } = new();
    public RimStyle RimStyle { get; set; } = new();
    public FrontAndRearSettings RimSize { get; set; } = new();
    public TrackWidthType TrackWidth { get; set; }

    // Aero and Appearance
    public String? FrontBumper { get; set; }
    public String? RearBumper { get; set; }
    public String? RearWing { get; set; }
    public String? SideSkirts { get; set; }
    public String? Hood { get; set; }

    // Conversions
    public String? Engine { get; set; }
    public DriveType Drivetrain { get; set; }
    public String? Aspiration { get; set; }
    public String? BodyKit { get; set; }
}
