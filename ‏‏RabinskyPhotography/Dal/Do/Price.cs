using System;
using System.Collections.Generic;

namespace Dal.Do;

public partial class Price
{
    public int Code { get; set; }

    public int PriceFor320Photos { get; set; }

    public int PriceForAnAdditionalHourBeyond7Hours { get; set; }

    public int PriceForAnAdditionalHourAfter1Am { get; set; }

    public virtual ICollection<Photographer> Photographers { get; set; } = new List<Photographer>();
}
