using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "ProductCode")]
[Index("AfsId", Name = "IX_ProdStatByAfs")]
public partial class ProdStat
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    public short ProductCode { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    public double? Price { get; set; }

    public double? Input { get; set; }

    public double? Ret { get; set; }

    public double? Cash { get; set; }

    public double? CashOutput { get; set; }

    public double? NonCashOutput { get; set; }

    public double? ExpectedRemainder { get; set; }

    public double? ActualRemainder { get; set; }

    public double? FinalRemainder { get; set; }

    public double? NonCashOutputCost { get; set; }

    public double? NonCashOutputCostWithDiscount { get; set; }

    public double? CashOutputCost { get; set; }

    public double? TotalCost { get; set; }

    public double? CashlessOverflowAmount { get; set; }

    public double WeightedAverageDensity { get; set; }
}
