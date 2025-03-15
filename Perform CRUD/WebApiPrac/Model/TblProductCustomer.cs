using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblProductCustomer
{
    public int ProductCustomerId { get; set; }

    public int? CustomerIdFk { get; set; }

    public int? ProductIdFk { get; set; }

    public int? ModelIdFk { get; set; }

    public int? AncillaryIdFk { get; set; }

    public DateTime? SalesDate { get; set; }

    public virtual TblAncillary? AncillaryIdFkNavigation { get; set; }

    public virtual TblCustomer? CustomerIdFkNavigation { get; set; }

    public virtual TblModel? ModelIdFkNavigation { get; set; }

    public virtual TblProduct? ProductIdFkNavigation { get; set; }
}
