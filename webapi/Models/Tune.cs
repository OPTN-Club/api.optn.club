namespace webapi.Models;

public class Tune
{
    public int Id { get; set; }
    public String Make { get; set; } = "";
    public String Model { get; set; } = "";
    public Upgrades Upgrades { get; set; } = new();
    public Settings Settings { get; set; } = new();
}
