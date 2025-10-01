using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ServiceCode", "WareCode")]
public partial class WaresBundling
{
    [Key]
    public int ServiceCode { get; set; }

    [Key]
    [Column("wareCode")]
    public int WareCode { get; set; }

    [Column("amount")]
    public double? Amount { get; set; }

    [Column("FLAGS")]
    public int? Flags { get; set; }
}
