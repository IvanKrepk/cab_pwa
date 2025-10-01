using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "RecId")]
public partial class TankMeasurements
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime MsrTime { get; set; }

    public int TankNo { get; set; }

    public int? FillingLevel { get; set; }

    public double? FuelVolume { get; set; }

    public int? WaterLevel { get; set; }

    public double? WaterVolume { get; set; }

    public double? Density { get; set; }

    public double? Temperature { get; set; }

    public byte DisableManualInput { get; set; }

    public short? LmLevel { get; set; }

    public double? LmRemainder { get; set; }

    public short? LmWaterLevel { get; set; }

    public double? LmDensity { get; set; }

    public double? LmTemperature { get; set; }
}
