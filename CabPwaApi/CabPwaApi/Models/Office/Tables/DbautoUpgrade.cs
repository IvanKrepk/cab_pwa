using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("DBAutoUpgrade")]
public partial class DbautoUpgrade
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public byte EnabledOperation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OperationType { get; set; } = null!;

    public short OperationState { get; set; }

    [Column("SQLScript")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Sqlscript { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PlanningDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExecutingDate { get; set; }

    public int ExecPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExecEnd { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Descript { get; set; }
}
