using System;
using System.Collections.Generic;

namespace BooksMagazin.Models;

public partial class Order
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public DateOnly DataZakaz { get; set; }

    public virtual ICollection<Basket> Baskets { get; set; } = new List<Basket>();

    public virtual User User { get; set; } = null!;
}
