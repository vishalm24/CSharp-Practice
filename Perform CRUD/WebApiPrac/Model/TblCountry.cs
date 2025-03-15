using System;
using System.Collections.Generic;

namespace WebApiPrac.Model;

public partial class TblCountry
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public virtual ICollection<TblArea> TblAreas { get; set; } = new List<TblArea>();

    public virtual ICollection<TblModel> TblModels { get; set; } = new List<TblModel>();
}
