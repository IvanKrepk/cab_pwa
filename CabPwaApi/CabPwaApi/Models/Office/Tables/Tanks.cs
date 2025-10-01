using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "TankNo")]
public partial class Tanks
{
    [Key]
    public short AfsId { get; set; }

    [Key]
    public short TankNo { get; set; }

    public short? ProductCode { get; set; }

    public double? DeadRemainder { get; set; }

    public int? LmCorrection { get; set; }

    public double? RelativeMeasurementError { get; set; }

    public int? PipelineVolume { get; set; }

    public double? SignalRemainderInPercent { get; set; }

    public byte DisableManualInput { get; set; }

    public double DensityCorrection { get; set; }
}
