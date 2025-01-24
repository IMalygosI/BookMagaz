using System;
using System.Collections.Generic;

namespace BooksMagazin.Models;

public partial class Tovar
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int ManufacturerId { get; set; }

    public decimal Price { get; set; }

    public int Count { get; set; }

    public decimal Skidka { get; set; }

    public string? Picture { get; set; }

    public string? Descriptoin { get; set; }

    public virtual ICollection<Basket> Baskets { get; set; } = new List<Basket>();

    public virtual Manufacturer Manufacturer { get; set; } = null!;
}
