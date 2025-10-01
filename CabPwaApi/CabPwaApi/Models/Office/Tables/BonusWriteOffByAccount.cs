using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class BonusWriteOffByAccount
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int AccountNumber { get; set; }

    public int WriteOffCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime WriteOffDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WriteOffReason { get; set; }

    public byte IsProcessed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ProcessedDate { get; set; }
}
