using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWaresJournalDocItems
{
    [Column("SupplyID")]
    public int SupplyId { get; set; }

    public int WareCode { get; set; }

    public double? Qty { get; set; }

    public double? Price { get; set; }

    public double? RetailPrice { get; set; }

    public double? OldRetailPrice { get; set; }

    public double? SelfPrice { get; set; }

    [Column("oldQty")]
    public double? OldQty { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WareName { get; set; }

    public double? VatValue { get; set; }

    [Column("GroupNAme")]
    [StringLength(32)]
    [Unicode(false)]
    public string GroupName { get; set; } = null!;
}
