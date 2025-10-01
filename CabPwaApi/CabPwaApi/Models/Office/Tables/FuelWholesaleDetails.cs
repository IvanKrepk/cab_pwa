using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("FuelWholesaleId", "SectionId")]
public partial class FuelWholesaleDetails
{
    [Key]
    [Column("FuelWholesaleID")]
    public int FuelWholesaleId { get; set; }

    [Key]
    [Column("SectionID")]
    public int SectionId { get; set; }

    public int ProductCode { get; set; }

    public double? ProductPrice { get; set; }

    public int MaxVolume { get; set; }

    public int RoughMaxQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedAt { get; set; }

    public int? Volume { get; set; }

    public double? Density { get; set; }

    public int? Qty { get; set; }

    public double? Temperature { get; set; }
}
