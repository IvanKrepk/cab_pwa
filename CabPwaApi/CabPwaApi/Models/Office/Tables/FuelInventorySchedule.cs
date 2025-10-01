using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "TimeKey")]
public partial class FuelInventorySchedule
{
    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public int TimeKey { get; set; }

    public int InventoryType { get; set; }

    public short IsEnabled { get; set; }
}
