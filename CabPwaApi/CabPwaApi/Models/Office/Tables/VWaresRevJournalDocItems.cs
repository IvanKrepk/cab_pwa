using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWaresRevJournalDocItems
{
    [Column("SupplyID")]
    public int SupplyId { get; set; }

    public int WareCode { get; set; }

    public double NewRetailPrice { get; set; }

    public double? OldRetailPrice { get; set; }

    public double? Quantity { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WareName { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string GroupName { get; set; } = null!;
}
