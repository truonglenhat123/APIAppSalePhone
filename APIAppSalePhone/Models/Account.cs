using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string? Password { get; set; }

    public DateTime CreateAt { get; set; }

    public string? Status { get; set; }

    public string Email { get; set; } = null!;

    public string? CreateBy { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime UpdateAt { get; set; }

    public string? Requestcode { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string? Avatar { get; set; }

    public int Role { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
