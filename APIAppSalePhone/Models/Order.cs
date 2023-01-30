using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? PaymentId { get; set; }

    public DateTime? OderDate { get; set; }

    public double Total { get; set; }

    public int AccountId { get; set; }

    public string? Status { get; set; }

    public DateTime CreateAt { get; set; }

    public string CreateBy { get; set; } = null!;

    public string UpdateBy { get; set; } = null!;

    public DateTime UpdateAt { get; set; }

    public string? OrderNote { get; set; }

    public int EmployeeId { get; set; }

    public int CustomerId { get; set; }

    public string AddressShipping { get; set; } = null!;

    public string PhoneShipping { get; set; } = null!;

    public virtual Account Account { get; set; } = null!;

    public virtual Customer Customer { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<OderDetail> OderDetails { get; } = new List<OderDetail>();

    public virtual Payment? Payment { get; set; }
}
