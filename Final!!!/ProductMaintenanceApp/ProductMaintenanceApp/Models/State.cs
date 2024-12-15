using System;
using System.Collections.Generic;

namespace ProductMaintenanceApp.Models;

public partial class State
{
    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public int FirstZipCode { get; set; }

    public int LastZipCode { get; set; }
}
