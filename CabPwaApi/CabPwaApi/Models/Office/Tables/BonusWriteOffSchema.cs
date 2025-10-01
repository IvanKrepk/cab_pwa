using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class BonusWriteOffSchema
{
    [Key]
    public int SchemaId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public int CardCategory { get; set; }

    public short WriteOffType { get; set; }

    public int? WriteOffPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateBegin { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateEnd { get; set; }

    public short NotInUse { get; set; }

    [Column("TaskID")]
    public int TaskId { get; set; }
}
