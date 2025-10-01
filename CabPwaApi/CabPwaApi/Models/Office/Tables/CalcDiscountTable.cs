using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CalcDiscountTable
{
    [Key]
    public int TableId { get; set; }

    public int SchemaId { get; set; }

    public int? PurseCode { get; set; }

    public int? Border { get; set; }

    public double? DefaultDiscountValue { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? BorderFormula { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? BonusIntoProductFormula { get; set; }
}
