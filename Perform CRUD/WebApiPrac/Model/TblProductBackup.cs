using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblProductBackup
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? ProductCost { get; set; }
}
