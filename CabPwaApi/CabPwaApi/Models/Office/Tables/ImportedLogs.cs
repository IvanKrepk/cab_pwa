using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "DstreamId", "DstreamDate", "DstreamTime", "DstreamSize")]
[Index("RecId", Name = "IX_ImportedLogsByRecID", IsUnique = true)]
public partial class ImportedLogs
{
    [Key]
    [Column("AfsID")]
    public short AfsId { get; set; }

    [Key]
    [Column("DstreamID")]
    public int DstreamId { get; set; }

    [Key]
    public int DstreamDate { get; set; }

    [Key]
    public int DstreamTime { get; set; }

    [Key]
    public int DstreamSize { get; set; }

    [Column("RecID")]
    public int RecId { get; set; }
}
