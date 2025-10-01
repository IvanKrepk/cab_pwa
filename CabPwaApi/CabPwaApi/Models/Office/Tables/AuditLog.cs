using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("RecordTime", Name = "IX_AuditLogByTime")]
public partial class AuditLog
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RecordTime { get; set; }

    [Column("AppID")]
    public int AppId { get; set; }

    [Column("UserID")]
    public int UserId { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    [Column("RID")]
    public int Rid { get; set; }

    public int MsgType { get; set; }

    [Column("MsgID")]
    public int MsgId { get; set; }

    [Column(TypeName = "text")]
    public string? MsgText { get; set; }
}
