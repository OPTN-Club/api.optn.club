using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.Models;

public class GearSettings
{
    public Boolean NA { get; set; }
    public String InternalRatios { get; set; } = "";

    [NotMapped]
    public int[] Ratios
    {
        get { return Array.ConvertAll(InternalRatios.Split(','), Int32.Parse); }
        set { InternalRatios = String.Join(',', value.Select(r => r.ToString()).ToArray()); }
    }

}
