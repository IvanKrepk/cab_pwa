using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("SeriesId", "CouponNumber")]
public partial class UsedCoupons
{
    [Key]
    [Column("SeriesID")]
    public int SeriesId { get; set; }

    [Key]
    public int CouponNumber { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime WhenUsed { get; set; }

    [Column("GcRecID")]
    public int GcRecId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column("EventGroupID")]
    public long? EventGroupId { get; set; }
}
