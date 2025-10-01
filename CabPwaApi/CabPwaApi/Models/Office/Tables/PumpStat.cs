using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "PumpNo")]
[Index("AfsId", Name = "IX_PumpStatByAfs")]
public partial class PumpStat
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    public short PumpNo { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    public short TankNo { get; set; }

    public short ProductCode { get; set; }

    public double? InitialCounter { get; set; }

    public double? Counter { get; set; }

    public double? Cash { get; set; }

    public double? CashOutput { get; set; }

    public double? NonCashOutput { get; set; }

    public double? MeasurerOutput { get; set; }

    public double? OverflowOutput { get; set; }

    public double? OverflowCost { get; set; }

    public double? UntracedOutput { get; set; }

    public double? CashlessOverflowAmount { get; set; }
}
