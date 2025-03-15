using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblArea
{
    public int AreaId { get; set; }

    public string? AreaName { get; set; }

    public int? CountryIdFk { get; set; }

    public virtual TblCountry? CountryIdFkNavigation { get; set; }
}
