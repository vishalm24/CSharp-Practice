using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblCustomer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerPhoneNumber { get; set; }

    public string? CustomerSsn { get; set; }

    public int? CustomerReferenceIdFk { get; set; }

    public virtual ICollection<TblAddress> TblAddresses { get; set; } = new List<TblAddress>();

    public virtual ICollection<TblProductCustomer> TblProductCustomers { get; set; } = new List<TblProductCustomer>();
}
