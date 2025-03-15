using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblProduct
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? ProductCost { get; set; }

    public virtual ICollection<TblProductCustomer> TblProductCustomers { get; set; } = new List<TblProductCustomer>();
}
