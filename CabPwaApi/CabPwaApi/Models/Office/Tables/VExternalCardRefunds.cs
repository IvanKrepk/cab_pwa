using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VExternalCardRefunds
{
    [Column("RID")]
    public int Rid { get; set; }

    public int PaymentType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CardNumber { get; set; } = null!;

    public double Price { get; set; }

    public int Qty { get; set; }

    public double Sum { get; set; }

    public int DiscountType { get; set; }

    public double DiscountValue { get; set; }

    public int IsUnclaimed { get; set; }
}
