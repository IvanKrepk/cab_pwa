using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ChangeTime", "ProductCode", "AfsId")]
[Index("AfsId", Name = "IX_PricesByAfsID")]
public partial class Prices
{
    [Key]
    [Column(TypeName = "datetime")]
    public DateTime ChangeTime { get; set; }

    [Key]
    public short ProductCode { get; set; }

    [Key]
    [Column("AfsID")]
    public short AfsId { get; set; }

    public short IsCurrent { get; set; }

    public double Price { get; set; }
}
