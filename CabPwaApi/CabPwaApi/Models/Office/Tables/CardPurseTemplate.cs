using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("TemplateId", "PurseContentCode")]
public partial class CardPurseTemplate
{
    [Key]
    [Column("TemplateID")]
    public int TemplateId { get; set; }

    [Column("PurseID")]
    public int PurseId { get; set; }

    public int PurseType { get; set; }

    [Key]
    public int PurseContentCode { get; set; }

    public double? DailyLimit { get; set; }

    public double? MonthlyLimit { get; set; }
}
