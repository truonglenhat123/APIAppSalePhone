using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public string PaymentName { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public string CreateBy { get; set; } = null!;

    public string? Status { get; set; }

    public string UpdateBy { get; set; } = null!;

    public DateTime? UpdateAt { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
