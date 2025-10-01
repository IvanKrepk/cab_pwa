using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("SupplyId", "SourceInfoCode")]
public partial class FuelSupplyDetails
{
    [Key]
    [Column("SupplyID")]
    public int SupplyId { get; set; }

    [Key]
    public int SourceInfoCode { get; set; }

    public int ProductCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? QualityPassportNumber { get; set; }

    public DateOnly? QualityPassportDate { get; set; }

    public int? TruckOrTrailerCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    public DateOnly? DocDate { get; set; }

    public DateOnly? SendDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FirstLead { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SecondLead { get; set; }

    [Column("DocTcTypeID")]
    public int? DocTcTypeId { get; set; }

    public int DocFillingLevel { get; set; }

    public double DocTemperature { get; set; }

    public double DocDensity { get; set; }

    public int DocVolume { get; set; }

    public int DocQty { get; set; }

    public int DocWaterQty { get; set; }

    [Column("TcTypeID")]
    public int? TcTypeId { get; set; }

    public int FillingLevel { get; set; }

    public double Temperature { get; set; }

    public double Density { get; set; }

    public int Volume { get; set; }

    public int FactQty { get; set; }

    public int WaterQty { get; set; }

    public double? NaturalLossRate { get; set; }

    public int Qty { get; set; }
}
