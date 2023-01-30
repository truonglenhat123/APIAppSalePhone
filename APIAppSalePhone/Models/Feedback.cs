﻿using System;
using System.Collections.Generic;

namespace APIAppSalePhone.Models;

public partial class Feedback
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int? RateStar { get; set; }

    public DateTime CreateAt { get; set; }

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string? Content { get; set; }

    public int ProductId { get; set; }

    public virtual Product Product { get; set; } = null!;
}
