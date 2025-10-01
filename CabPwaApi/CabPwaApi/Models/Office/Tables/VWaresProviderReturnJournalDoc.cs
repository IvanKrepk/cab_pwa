using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWaresProviderReturnJournalDoc
{
    [Column("RID")]
    public int Rid { get; set; }

    [Column("OpID")]
    public int OpId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OpTime { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastChangeTime { get; set; }

    public int? InternalDocKind { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public int? RequestSupplierCode { get; set; }

    public int? OtherSideCode { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string OtherSideName { get; set; } = null!;

    public byte? JournalDocKind { get; set; }

    [StringLength(18)]
    [Unicode(false)]
    public string JournalDocName { get; set; } = null!;

    public double? SelfSumDoc { get; set; }

    public double? RetailSumDoc { get; set; }

    public double? QuantityDoc { get; set; }

    public byte? IsReversed { get; set; }
}
