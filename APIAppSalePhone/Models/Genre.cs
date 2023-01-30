using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Genre
{
    public int GenreId { get; set; }

    public string GenreName { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public string CreateBy { get; set; } = null!;

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateAt { get; set; }

    public virtual ICollection<OderDetail> OderDetails { get; } = new List<OderDetail>();

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
