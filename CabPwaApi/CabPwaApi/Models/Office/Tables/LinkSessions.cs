using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("EndTime", "AfsId", Name = "IX_LinkSessionsByTimeAndAfs")]
public partial class LinkSessions
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndTime { get; set; }

    public short CompletedSuccessfully { get; set; }

    [Column("VerRecID")]
    public int? VerRecId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? OfficeVer { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? AfsVer { get; set; }
}
