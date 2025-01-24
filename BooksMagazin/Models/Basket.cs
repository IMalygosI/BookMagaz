using System;
using System.Collections.Generic;

namespace BooksMagazin.Models;

public partial class Basket
{
    public int Id { get; set; }

    public int TovarId { get; set; }

    public int OrderId { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Tovar Tovar { get; set; } = null!;
}
