namespace webapi.Models;

public class TuneStatistics
{
    public int PI { get; set; }
    public PIClass Classification { get; set; }
    public int Horsepower { get; set; }
    public int Torque { get; set; }
    public int Weight { get; set; }
    public int Balance { get; set; }
    public int TopSpeed { get; set; }
    public int ZeroToSixty { get; set; }
    public int ZeroToHundred { get; set; }
    public String? ShareCode { get; set; }
}
