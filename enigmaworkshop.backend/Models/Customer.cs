﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace enigmaworkshop.backend.Models;

public partial class Customer
{
    public string Id { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly? DoB { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? Rank { get; set; }

    public double? Point { get; set; }

    public string? User { get; set; }

    [JsonIgnore]
    public virtual User? UserNavigation { get; set; }
}
