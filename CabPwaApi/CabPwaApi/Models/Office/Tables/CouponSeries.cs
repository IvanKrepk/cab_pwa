using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("CouponCode", "Series", Name = "IX_CouponSeriesByCouponCodeAndSeries", IsUnique = true)]
public partial class CouponSeries
{
    [Key]
    [Column("SeriesID")]
    public int SeriesId { get; set; }

    public int CouponCode { get; set; }

    public int ProductCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Series { get; set; } = null!;

    public int Nominal { get; set; }
}
