using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CalcDiscountSchema
{
    [Key]
    public int SchemaId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public int? DiscountType { get; set; }

    public short? IsBonusDiscount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateBegin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateEnd { get; set; }

    public int? CardCategory { get; set; }

    public int? SaleType { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? BorderFormula { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? BonusToBorderFormula { get; set; }

    public short? NotInUse { get; set; }

    public byte? DynamicDiscountCalculation { get; set; }
}
