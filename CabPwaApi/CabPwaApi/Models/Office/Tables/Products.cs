using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Products
{
    [Key]
    public short ProductCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ProductName { get; set; } = null!;

    public double? CurPrice { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ChoiceChar { get; set; }

    public short? FuelType { get; set; }

    public double? MinDensity { get; set; }

    public double? MaxDensity { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? EquivCodes { get; set; }

    public double? MaxInputDensityDelta { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? NameForCheck { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FuelClasses { get; set; }

    [Column("VAT")]
    public double? Vat { get; set; }

    public byte TaxSystem { get; set; }

    public int EcrItemType { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? FullName { get; set; }

    public double? AvgDensity { get; set; }

    public int? AgentAttribute { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? UnitName { get; set; }

    [Column("AgentOwnerContractorID")]
    public int? AgentOwnerContractorId { get; set; }
}
