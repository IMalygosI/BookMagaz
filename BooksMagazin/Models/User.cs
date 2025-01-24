﻿using System;
using System.Collections.Generic;

namespace BooksMagazin.Models;

public partial class User
{
    public int Id { get; set; }

    public string FioNamOt { get; set; } = null!;

    public int RoleId { get; set; }

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int GenderId { get; set; }

    public virtual Gender Gender { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual Role Role { get; set; } = null!;
}
