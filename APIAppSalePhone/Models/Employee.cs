using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmployeeName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
