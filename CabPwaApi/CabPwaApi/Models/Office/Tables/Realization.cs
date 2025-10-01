using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "ProductCode", "PaymentType")]
[Index("AfsId", Name = "IX_RealizationByAfs")]
public partial class Realization
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    public short ProductCode { get; set; }

    [Key]
    public int PaymentType { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    public double? Amount { get; set; }

    public double? Cost { get; set; }

    public double? Nominal { get; set; }

    public double? Paid { get; set; }
}
