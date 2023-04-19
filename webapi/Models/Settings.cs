namespace webapi.Models;

public class Settings
{
    public int Id { get; set; }
    public FrontAndRearSettingsWithUnits TirePressure { get; set; } = new();
    public GearSettings Gears { get; set; } = new();
    public FrontAndRearSettings Camber { get; set; } = new();
    public FrontAndRearSettings Toe { get; set; } = new();
    public String? Caster { get; set; }
    public FrontAndRearSettings ARB { get; set; } = new();
    public FrontAndRearSettingsWithUnits Springs { get; set; } = new();
    public FrontAndRearSettingsWithUnits RideHeight { get; set; } = new();
    public FrontAndRearSettings Damping { get; set; } = new();
    public FrontAndRearSettings Bump { get; set; } = new();
    public FrontAndRearSettingsWithUnits Aero { get; set; } = new();
    public BrakeSettings Brakes { get; set; } = new();
    public DifferentialSettings Differential { get; set; } = new();


}
