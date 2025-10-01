using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class AccessAuthority
{
    [Key]
    [Column("RecordID")]
    public int RecordId { get; set; }

    [Column("UID")]
    public int Uid { get; set; }

    public int AccessObject { get; set; }

    public int AccessMode { get; set; }

    [Column("addOption")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AddOption { get; set; }
}
