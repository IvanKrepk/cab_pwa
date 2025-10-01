using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Ver", "AfsId")]
public partial class TankBookRemainderOffsets
{
    [Key]
    public int Ver { get; set; }

    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("RID")]
    public int Rid { get; set; }

    public int TankNo { get; set; }

    public int Ordr { get; set; }

    public bool IsDeletion { get; set; }

    public int Flags { get; set; }

    public double? BookVolOffset { get; set; }

    public double? BookMassOffset { get; set; }

    public double? VolOffset { get; set; }
}
