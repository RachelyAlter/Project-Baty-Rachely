using System;
using System.Collections.Generic;

namespace Dal.Do;

public partial class Photographer
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string LastName { get; set; } = null!;

    public int PriceCode { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Price PriceCodeNavigation { get; set; } = null!;
}
