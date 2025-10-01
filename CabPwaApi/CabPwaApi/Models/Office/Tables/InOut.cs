using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "Ordr", "TankNo")]
[Index("AfsId", Name = "IX_InOutByAfs")]
[Index("FuelSupplyId", Name = "IxInOutBySupplyID")]
public partial class InOut
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    public int Ordr { get; set; }

    [Key]
    public short TankNo { get; set; }

    public short ProductCode { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    public short IsInput { get; set; }

    public short? ProviderCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DocumentInfo { get; set; }

    public double? StartTime { get; set; }

    public short? LmInitialLevel { get; set; }

    public double? LmInitialRemainder { get; set; }

    public short? LmInitialWaterLevel { get; set; }

    public double? LmInitialTemperature { get; set; }

    public double? LmInitialDensity { get; set; }

    public double? EndTime { get; set; }

    public short? LmFinalLevel { get; set; }

    public double? LmFinalRemainder { get; set; }

    public short? LmFinalWaterLevel { get; set; }

    public double? LmFinalTemperature { get; set; }

    public double? LmFinalDensity { get; set; }

    public double? AmountByDocument { get; set; }

    public double? DensityByDocument { get; set; }

    public double? TemperatureByDocument { get; set; }

    public double? WeightByDocument { get; set; }

    public double? Amount { get; set; }

    public double? AgreedMiss { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? CarNumber { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? Driver { get; set; }

    public int? FuelDriverCode { get; set; }

    public int? TankTruckCode { get; set; }

    public double? DocDate { get; set; }

    public double? DocPrice { get; set; }

    public double? DensityInTankTruck { get; set; }

    public double? TemperatureInTankTruck { get; set; }

    public double? BookVolume { get; set; }

    public double? BookMass { get; set; }

    public int? TrailerCode { get; set; }

    public int? SectionNumber { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Waybill { get; set; }

    [Column("FuelBaseID")]
    public int? FuelBaseId { get; set; }

    [Column("FuelSupplyID")]
    public int? FuelSupplyId { get; set; }
}
