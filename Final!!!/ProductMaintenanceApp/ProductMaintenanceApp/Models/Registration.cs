using System;
using System.Collections.Generic;

namespace ProductMaintenanceApp.Models;

public partial class Registration
{
    public int CustomerId { get; set; }

    public string ProductCode { get; set; } = null!;

    public DateTime RegistrationDate { get; set; }
}
