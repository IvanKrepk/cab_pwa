using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "ClientCode", "ProductCode")]
public partial class CurCredit
{
    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public int ClientCode { get; set; }

    public double? CreditSum { get; set; }

    [Key]
    public int ProductCode { get; set; }
}
