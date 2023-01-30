using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public bool? IsDelete { get; set; }

    public double OldPrice { get; set; }

    public double NewPrice { get; set; }

    public string? Image { get; set; }

    public bool? Hot { get; set; }

    public int GenreId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Description { get; set; }

    public string? Descriptionshort { get; set; }

    public string? Color { get; set; }

    public string? KichThuocManHinh { get; set; }

    public string? DophangiaiManHinh { get; set; }

    public string? Bonhotrong { get; set; }

    public string? CameraTruoc { get; set; }

    public string? CameraSau { get; set; }

    public string? Ram { get; set; }

    public string? Pin { get; set; }

    public string? Sim { get; set; }

    public string? HeDieuHanh { get; set; }

    public string? Cpu { get; set; }

    public int? SoLuong { get; set; }

    public int? BrandId { get; set; }

    public string? Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public int DisscountId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Discount Disscount { get; set; } = null!;

    public virtual ICollection<Feedback> Feedbacks { get; } = new List<Feedback>();

    public virtual Genre Genre { get; set; } = null!;

    public virtual ICollection<OderDetail> OderDetails { get; } = new List<OderDetail>();
}
