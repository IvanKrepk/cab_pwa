using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "ProductCode", "GroupCode")]
public partial class GrpDiscounts
{
    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public int ProductCode { get; set; }

    [Key]
    public int GroupCode { get; set; }

    public short DiscountType { get; set; }

    public double DiscountValue { get; set; }
}
