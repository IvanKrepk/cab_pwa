using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class DelayedBonusAdditions
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    public int? AccountNumber { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? AddData { get; set; }
}
