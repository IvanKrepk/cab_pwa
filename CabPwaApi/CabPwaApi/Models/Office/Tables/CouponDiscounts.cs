using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("CouponCode", "ProductCode", "Afsid", Name = "CouponDiscounts_uq", IsUnique = true)]
public partial class CouponDiscounts
{
    public int CouponCode { get; set; }

    public int ProductCode { get; set; }

    public int DiscountType { get; set; }

    public double Discount { get; set; }

    [Column("AFSID")]
    public int Afsid { get; set; }

    [Key]
    [Column("ID")]
    public int Id { get; set; }
}
