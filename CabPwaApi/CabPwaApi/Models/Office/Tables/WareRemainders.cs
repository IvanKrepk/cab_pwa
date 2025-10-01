using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("WareCode", "AfsId")]
public partial class WareRemainders
{
    [Key]
    public int WareCode { get; set; }

    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    public double Remainder { get; set; }

    public double? SelfPrice { get; set; }

    public double? Price { get; set; }
}
