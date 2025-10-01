using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "ProductCode")]
public partial class CurProdStat
{
    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public short ProductCode { get; set; }

    public double? Price { get; set; }

    public double? Input { get; set; }

    public double? Ret { get; set; }

    public double? Cash { get; set; }

    public double? CashOutput { get; set; }

    public double? NonCashOutput { get; set; }

    public double? Remainder { get; set; }

    public double? CashlessOverflowAmount { get; set; }
}
