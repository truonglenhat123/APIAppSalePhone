using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Discount
{
    public int DisscountId { get; set; }

    public string DiscountName { get; set; } = null!;

    public DateTime DiscountStar { get; set; }

    public DateTime DiscountEnd { get; set; }

    public double DiscountPrice { get; set; }

    public string? DiscountCode { get; set; }

    public DateTime CreateAt { get; set; }

    public string CreateBy { get; set; } = null!;

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateAt { get; set; }

    public int Quantity { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
