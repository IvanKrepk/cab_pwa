using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AccountNumber", "ProductCode")]
public partial class ExtraCardPurses
{
    [Key]
    public int AccountNumber { get; set; }

    [Key]
    public int ProductCode { get; set; }

    public int PurseType { get; set; }

    public double? DailyLimit { get; set; }

    public double? MonthlyLimit { get; set; }

    public double? Rest { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RestUpdateTime { get; set; }

    public double? UnreturnedRest { get; set; }
}
