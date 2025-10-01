using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "Afsid", "ProductCode", "PaymentType", "Price", "UndiscountedPrice")]
public partial class CashRealization
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("AFSID")]
    public int Afsid { get; set; }

    [Key]
    public int ProductCode { get; set; }

    [Key]
    public int PaymentType { get; set; }

    [Key]
    public double Price { get; set; }

    [Key]
    public double UndiscountedPrice { get; set; }

    public double Qty { get; set; }
}
