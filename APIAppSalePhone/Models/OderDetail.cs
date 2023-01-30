using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class OderDetail
{
    public int ProductId { get; set; }

    public int GenreId { get; set; }

    public int DisscountId { get; set; }

    public int OrderId { get; set; }

    public double Price { get; set; }

    public string? Status { get; set; }

    public string Transection { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateAt { get; set; }

    public int Quantity { get; set; }

    public virtual Genre Genre { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
