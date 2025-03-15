using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblAncillary
{
    public int Id { get; set; }

    public string? AncillaryName { get; set; }

    public decimal? AncillaryCost { get; set; }

    public virtual ICollection<TblProductCustomer> TblProductCustomers { get; set; } = new List<TblProductCustomer>();
}
