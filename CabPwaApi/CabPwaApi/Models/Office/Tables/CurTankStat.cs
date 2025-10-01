using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "TankNo")]
public partial class CurTankStat
{
    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public short TankNo { get; set; }

    public short? ProductCode { get; set; }

    public double? Input { get; set; }

    public double? Ret { get; set; }

    public double? Cash { get; set; }

    public double? CashOutput { get; set; }

    public double? NonCashOutput { get; set; }

    public double? InitialRemainder { get; set; }

    public double? InitialBookRemainder { get; set; }

    public double? Remainder { get; set; }

    public double? BookRemainder { get; set; }

    public double? CashlessOverflowAmount { get; set; }

    public short? LmLevel { get; set; }

    public double? LmRemainder { get; set; }

    public short? LmWaterLevel { get; set; }

    public double? LmDensity { get; set; }

    public double? LmTemperature { get; set; }

    public double? MaxVolume { get; set; }
}
