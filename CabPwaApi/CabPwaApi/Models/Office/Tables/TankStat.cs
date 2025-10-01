using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "TankNo")]
[Index("AfsId", Name = "IX_TankStatByAfs")]
public partial class TankStat
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    public short TankNo { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    public short? ProductCode { get; set; }

    public short? InitialLevel { get; set; }

    public double? InitialRemainder { get; set; }

    public short? LmInitialLevel { get; set; }

    public double? LmInitialRemainder { get; set; }

    public short? LmInitialWaterLevel { get; set; }

    public double? LmInitialDensity { get; set; }

    public double? LmInitialTemperature { get; set; }

    public short? FinalLevel { get; set; }

    public double? FinalRemainder { get; set; }

    public short? FinalWaterLevel { get; set; }

    public double? FinalDensity { get; set; }

    public short? LmFinalLevel { get; set; }

    public double? LmFinalRemainder { get; set; }

    public short? LmFinalWaterLevel { get; set; }

    public double? LmFinalDensity { get; set; }

    public double? LmFinalTemperature { get; set; }

    public double? Input { get; set; }

    public double? Ret { get; set; }

    public double? Cash { get; set; }

    public double? CashOutput { get; set; }

    public double? NonCashOutput { get; set; }

    public double? ExpectedRemainder { get; set; }

    public int? ActualLevel { get; set; }

    public double? ActualRemainder { get; set; }

    public double? CashlessOverflowAmount { get; set; }

    public double? BookRemainder { get; set; }

    public double? InitialBookRemainder { get; set; }

    public double? NormalizedRealization { get; set; }

    public double? FinalTemperature { get; set; }

    public short? InitialWaterLevel { get; set; }

    public double? InitialTemperature { get; set; }

    public double? InitialDensity { get; set; }

    public double? InitialBookWeight { get; set; }

    public double? FinalBookWeight { get; set; }

    public double? RealizationWeight { get; set; }

    public double? AverageDensity { get; set; }

    public double? WeightedAverageDensity { get; set; }

    public double? AverageMeasuredDensity { get; set; }

    public double? InventarizedMass { get; set; }

    public double? InventarizedVolume { get; set; }

    public int? PipelineVolume { get; set; }

    public double? InitialBookDensity { get; set; }
}
