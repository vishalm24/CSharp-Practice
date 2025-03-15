using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblModel
{
    public int ModelId { get; set; }

    public string? ModelName { get; set; }

    public string? ModelBrand { get; set; }

    public string? ManufacturerName { get; set; }

    public int? CountryIdFk { get; set; }

    public virtual TblCountry? CountryIdFkNavigation { get; set; }

    public virtual ICollection<TblProductCustomer> TblProductCustomers { get; set; } = new List<TblProductCustomer>();
}
