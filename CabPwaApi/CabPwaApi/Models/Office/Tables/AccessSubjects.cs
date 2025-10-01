using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class AccessSubjects
{
    [Key]
    [Column("UID")]
    public int Uid { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? Login { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? FullName { get; set; }

    public short? Enabled { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? PasswordHash { get; set; }

    [Column("isAdmin")]
    public short? IsAdmin { get; set; }

    public short? HasFullAccess { get; set; }

    [Column("CardID")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CardId { get; set; }

    [Column("StaffID")]
    public int? StaffId { get; set; }
}
