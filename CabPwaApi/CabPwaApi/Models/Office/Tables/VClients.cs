using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VClients
{
    public short ClientCode { get; set; }

    [Column("ContractorID")]
    public int ContractorId { get; set; }

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
    [StringLength(12)]
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

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNumber { get; set; }

    [Column("props")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Props { get; set; }

    [Column("KPP")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Kpp { get; set; }

    public short IsOurFirm { get; set; }

    [Column("BIK")]
    [StringLength(9)]
    [Unicode(false)]
    public string? Bik { get; set; }

    public short Inactive { get; set; }

    [Column("TradeObjectID")]
    public int? TradeObjectId { get; set; }

    public short? AddInStopListAutomatic { get; set; }

    public int? SubdivisionCode { get; set; }

    public byte BalanceByProduct { get; set; }

    public int Version { get; set; }

    public short? InStopListReason { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? CommonStopListReasonDesc { get; set; }

    public short InStopList { get; set; }

    public double MoneyBalance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime MoneyBalanceUpdateTime { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? MoneyInStopListReasonDesc { get; set; }

    public byte MoneyInStopList { get; set; }

    public double MoneyCreditDepth { get; set; }

    public short? MoneyInStopListReason { get; set; }

    public double? Balance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BalanceUpdateTime { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? InStopListReasonDesc { get; set; }

    public double? CreditDepth { get; set; }

    public DateOnly? TerminationServiceDate { get; set; }

    public byte UseCreditReceiptPaymentType { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? LegalAddress { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Director { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DirectorJob { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ChiefAccountant { get; set; }

    public byte ContractWork { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MoneyInStopListDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InStopListDate { get; set; }

    public byte UsedThresholdDiscount { get; set; }
}
