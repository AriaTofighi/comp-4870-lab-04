using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab04.Models;

public class City
{
    [Key]
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public int? Population { get; set; }

    public string? ProvinceCode { get; set; }

    [ForeignKey("ProvinceCode")]
    public Province? province { get; set; }
}