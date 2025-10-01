using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("OpId", "WareCode")]
public partial class WareRevItems
{
    [Key]
    [Column("OpID")]
    public int OpId { get; set; }

    [Key]
    public int WareCode { get; set; }

    public double? OldRetailPrice { get; set; }

    public double RetailPrice { get; set; }

    public double? Quantity { get; set; }
}
