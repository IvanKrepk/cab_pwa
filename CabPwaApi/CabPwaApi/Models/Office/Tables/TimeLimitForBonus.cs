using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class TimeLimitForBonus
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int SchemaId { get; set; }

    public int? LimitType { get; set; }

    public int? WkDay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LimitDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeBeg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? TimeEnd { get; set; }

    [ForeignKey("SchemaId")]
    [InverseProperty("TimeLimitForBonus")]
    public virtual BonusAddSchema Schema { get; set; } = null!;
}
