using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
