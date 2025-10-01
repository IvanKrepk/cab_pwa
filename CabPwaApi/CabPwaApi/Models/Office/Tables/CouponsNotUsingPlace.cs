using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("CouponCode", "AfsId")]
public partial class CouponsNotUsingPlace
{
    [Key]
    public short CouponCode { get; set; }

    [Key]
    [Column("AfsID")]
    public short AfsId { get; set; }
}
