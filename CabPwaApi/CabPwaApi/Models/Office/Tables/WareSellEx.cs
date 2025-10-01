using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "WareCode", "PaymentId")]
[Index("AfsId", Name = "IX_WareSellExByAFS")]
[Index("WareCode", Name = "IX_WareSellExByWare")]
public partial class WareSellEx
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public int WareCode { get; set; }

    [Key]
    [Column("PaymentID")]
    public int PaymentId { get; set; }

    public double? Amount { get; set; }

    public double? Cost { get; set; }

    public double? SelfCost { get; set; }

    public double? OrigCost { get; set; }
}
