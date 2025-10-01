using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Wares
{
    [Key]
    public int Code { get; set; }

    public int GroupCode { get; set; }

    public int? UnitCode { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? BarCode { get; set; }

    public int? Version { get; set; }

    public short? IsService { get; set; }

    [Column("NDS")]
    public double? Nds { get; set; }

    [Column("NP")]
    public double? Np { get; set; }

    [Column("name")]
    [StringLength(128)]
    [Unicode(false)]
    public string? Name { get; set; }

    public short IsInactive { get; set; }

    public short? SellOnlyInBundling { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime CreateDate { get; set; }

    public short? EnableFreePrice { get; set; }

    [Column("ManufacturerID")]
    public int? ManufacturerId { get; set; }

    public int? AnalogGroupCode { get; set; }

    public byte IsAlco { get; set; }

    public int? AlcoWareTypeCode { get; set; }

    public double? AlcoVolume { get; set; }

    public int? AlcoImporterCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ExtIdentifier { get; set; }

    public int? OriginId { get; set; }

    public double? WriteOffNorm { get; set; }

    public int ForbidIncome { get; set; }

    public int EcrItemType { get; set; }

    [Column("GTIN")]
    public long? Gtin { get; set; }
}
