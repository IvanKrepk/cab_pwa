using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWaresWareSellJournalDoc
{
    [Column("RID")]
    public int Rid { get; set; }

    [Column("OpID")]
    public int OpId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OpTime { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    [StringLength(29)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Reason { get; set; } = null!;

    public int? LastChangeTime { get; set; }

    public int? InternalDocKind { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Notes { get; set; } = null!;

    public int? RequestSupplierCode { get; set; }

    public int? OtherSideCode { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string OtherSideName { get; set; } = null!;

    public int JournalDocKind { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string JournalDocName { get; set; } = null!;

    public double? SelfSumDoc { get; set; }

    public double? RetailSumDoc { get; set; }

    public double? QuantityDoc { get; set; }

    public int IsReversed { get; set; }
}
