using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CardInfoTemplate
{
    [Key]
    [Column("TemplateID")]
    public int TemplateId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TemplateName { get; set; } = null!;

    public double? MinimalMoneyRest { get; set; }

    public double? MaxDailyDebit { get; set; }
}
