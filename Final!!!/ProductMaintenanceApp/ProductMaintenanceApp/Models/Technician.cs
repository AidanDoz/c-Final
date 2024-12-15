using System;
using System.Collections.Generic;

namespace ProductMaintenanceApp.Models;

public partial class Technician
{
    public int TechId { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();
}
