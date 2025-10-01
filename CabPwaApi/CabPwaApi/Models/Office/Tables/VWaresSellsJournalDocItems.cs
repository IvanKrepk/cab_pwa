using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWaresSellsJournalDocItems
{
    [Column("SupplyID")]
    public int SupplyId { get; set; }

    public int WareCode { get; set; }

    public double? Cost { get; set; }

    public double? Qty { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WareName { get; set; }
}
