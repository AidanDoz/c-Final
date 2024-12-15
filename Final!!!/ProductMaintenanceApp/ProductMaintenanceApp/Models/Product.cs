using System;
using System.Collections.Generic;

namespace ProductMaintenanceApp.Models;

public partial class Product
{
    public string ProductCode { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Version { get; set; }

    public DateTime ReleaseDate { get; set; }

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();
}
