using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VOurFirms
{
    public short ClientCode { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string ClientName { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string? FullName { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bank { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? CorrAccount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CorrBank { get; set; }

    [Column("INN")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Inn { get; set; }

    [Column("OKPO")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Okpo { get; set; }

    [Column("OKONH")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Okonh { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? Phones { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? ContactFace { get; set; }

    public double? Balance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BalanceUpdateTime { get; set; }

    public int Version { get; set; }

    public short InStopList { get; set; }

    public double? CreditDepth { get; set; }

    public short Inactive { get; set; }

    [Column("provider_code")]
    public int? ProviderCode { get; set; }

    [Column("props", TypeName = "text")]
    public string? Props { get; set; }

    public short? IsOurFirm { get; set; }

    [Column("TradeObjectID")]
    public int? TradeObjectId { get; set; }

    public short? AddInStopListAutomatic { get; set; }

    public short? InStopListReason { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? InStopListReasonDesc { get; set; }

    public int? SubdivisionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNumber { get; set; }

    [Column("ContractorID")]
    public int? ContractorId { get; set; }

    public byte BalanceByProduct { get; set; }

    public DateOnly? TerminationServiceDate { get; set; }

    public byte UseCreditReceiptPaymentType { get; set; }
}
