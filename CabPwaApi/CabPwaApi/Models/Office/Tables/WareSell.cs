using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "WareCode")]
[Index("AfsId", "Rid", Name = "IX_WareSellByAFS")]
[Index("WareCode", "Rid", Name = "IX_WareSellByWare")]
public partial class WareSell
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public int WareCode { get; set; }

    public double? Amount { get; set; }

    public double? Cost { get; set; }

    public double? SelfCost { get; set; }
}
