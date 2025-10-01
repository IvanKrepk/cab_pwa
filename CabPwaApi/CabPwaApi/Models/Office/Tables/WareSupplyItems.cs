using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("SupplyId", "WareCode")]
public partial class WareSupplyItems
{
    [Key]
    [Column("SupplyID")]
    public int SupplyId { get; set; }

    [Key]
    public int WareCode { get; set; }

    public double Qty { get; set; }

    public double? Price { get; set; }

    public double? RetailPrice { get; set; }

    public double? OldRetailPrice { get; set; }

    public double? SelfPrice { get; set; }

    [Column("oldQty")]
    public double? OldQty { get; set; }

    public double? VatValue { get; set; }
}
