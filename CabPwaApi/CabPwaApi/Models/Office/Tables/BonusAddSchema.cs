using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class BonusAddSchema
{
    [Key]
    public int SchemaId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DateBegin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateEnd { get; set; }

    public int? CardCategory { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? DefaultFormula { get; set; }

    public int? SaleType { get; set; }

    public short? NotInUse { get; set; }

    [InverseProperty("Schema")]
    public virtual ICollection<TimeLimitForBonus> TimeLimitForBonus { get; set; } = new List<TimeLimitForBonus>();
}
