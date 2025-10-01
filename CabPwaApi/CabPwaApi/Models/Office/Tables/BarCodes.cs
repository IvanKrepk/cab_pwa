using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("BarCode", "WareCode")]
[Index("WareCode", Name = "IX_BarCodesByWareCode")]
public partial class BarCodes
{
    [Key]
    [StringLength(128)]
    [Unicode(false)]
    public string BarCode { get; set; } = null!;

    [Key]
    public int WareCode { get; set; }

    public int UnitCode { get; set; }

    public double Multiplier { get; set; }
}
