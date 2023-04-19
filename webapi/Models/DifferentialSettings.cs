namespace webapi.Models;

public class DifferentialSettings
{
    public class AccelDecelSettings
    {
        public int Accel { get; set; }
        public int Decel { get; set; }
    }

    public Boolean NA { get; set; }
    public AccelDecelSettings Front { get; set; } = new();
    public AccelDecelSettings Rear { get; set; } = new();
    public int Center { get; set; }
}
