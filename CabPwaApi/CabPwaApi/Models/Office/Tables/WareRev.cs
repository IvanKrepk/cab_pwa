using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("OpTime", Name = "IX_wareRevByOpTime")]
public partial class WareRev
{
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("OpID")]
    public int OpId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OpTime { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [Column("InternalDocID")]
    [StringLength(16)]
    [Unicode(false)]
    public string? InternalDocId { get; set; }

    public byte? IsReversed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReversedDate { get; set; }
}
