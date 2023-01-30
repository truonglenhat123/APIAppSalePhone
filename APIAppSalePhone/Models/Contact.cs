using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Content { get; set; } = null!;

    public string CreateBy { get; set; } = null!;

    public DateTime CreateAt { get; set; }

    public string Status { get; set; } = null!;

    public string UpdateBy { get; set; } = null!;

    public DateTime? UpdateAt { get; set; }
}
