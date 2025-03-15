using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblAddress
{
    public int AddressId { get; set; }

    public int? CustomerId { get; set; }

    public string? Address1 { get; set; }

    public string? City { get; set; }

    public virtual TblCustomer? Customer { get; set; }
}
