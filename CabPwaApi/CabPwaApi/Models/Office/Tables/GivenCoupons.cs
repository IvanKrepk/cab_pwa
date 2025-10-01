using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("ClientCode", Name = "IX_GivenCouponsByClientCode")]
[Index("Dt", Name = "IX_GivenCouponsByDT")]
[Index("SeriesId", "FirstNumber", "LastNumber", Name = "IX_GivenCouponsBySeriesIDAndNumbers")]
public partial class GivenCoupons
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    [Column("DT", TypeName = "datetime")]
    public DateTime Dt { get; set; }

    public int ClientCode { get; set; }

    public int CouponCode { get; set; }

    public int ProductCode { get; set; }

    [Column("SeriesID")]
    public int SeriesId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Series { get; set; } = null!;

    public int Nominal { get; set; }

    public short InLiters { get; set; }

    public int FirstNumber { get; set; }

    public int LastNumber { get; set; }

    public int Remainder { get; set; }

    public int Version { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public double? Price { get; set; }

    public int? Refunded { get; set; }

    public int? Discarded { get; set; }

    public int? ItemShipment { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ContractNumber { get; set; }
}
