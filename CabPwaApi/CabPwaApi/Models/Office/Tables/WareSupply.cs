using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("InternalDocId", Name = "IX_WareSupplyByDocID")]
[Index("OpTime", Name = "IX_WareSupplyByOpTime")]
public partial class WareSupply
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

    public short IsSupply { get; set; }

    public short? IsExternal { get; set; }

    public int? OtherSideCode { get; set; }

    [Column("InternalDocID")]
    [StringLength(16)]
    [Unicode(false)]
    public string? InternalDocId { get; set; }

    [Column("SourceDocID")]
    [StringLength(16)]
    [Unicode(false)]
    public string? SourceDocId { get; set; }

    [Column("internalDocKind")]
    public int? InternalDocKind { get; set; }

    [Column("reason")]
    [StringLength(250)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastChangeTime { get; set; }

    public int? RequestSupplierCode { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public byte? JournalDocKind { get; set; }

    public byte? IsReversed { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReversedDate { get; set; }
}
