using System;
using System.Collections.Generic;

namespace ProductMaintenanceApp.Models;

public partial class Incident
{
    public int IncidentId { get; set; }

    public int CustomerId { get; set; }

    public string ProductCode { get; set; } = null!;

    public int TechId { get; set; }

    public DateTime DateOpened { get; set; }

    public DateTime? DateClosed { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public virtual Customer Customer { get; set; } = null!;

    public virtual Product ProductCodeNavigation { get; set; } = null!;

    public virtual Technician Tech { get; set; } = null!;
}
