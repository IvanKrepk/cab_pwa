using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "OperationId")]
public partial class ExternalCardOperations
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("OperationID")]
    public int OperationId { get; set; }

    [Column("TradeObjectID")]
    public int TradeObjectId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OperationTime { get; set; }

    public int OperationType { get; set; }

    public int Flags { get; set; }

    [Column("TermID")]
    public int TermId { get; set; }

    [Column("TranID")]
    public int TranId { get; set; }

    [Column("BaseTranID")]
    public int BaseTranId { get; set; }

    public int PaymentType { get; set; }

    public int CardType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CardNumber { get; set; } = null!;

    public int PumpNo { get; set; }

    public int ProductCode { get; set; }

    public int InitQty { get; set; }

    public double InitPrice { get; set; }

    public double InitSum { get; set; }

    public int Qty { get; set; }

    public double Price { get; set; }

    public double Sum { get; set; }

    public int DiscountType { get; set; }

    public double DiscountValue { get; set; }

    [Column("PumpJobID")]
    public long PumpJobId { get; set; }

    [Column("SBCardNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SbcardNo { get; set; }

    [Column("SBRemovedBonuses")]
    public int? SbremovedBonuses { get; set; }

    [Column("SBAddedBonuses")]
    public int? SbaddedBonuses { get; set; }

    [Column("LnrCardTypeID")]
    public int? LnrCardTypeId { get; set; }

    public int? LnrBonusesGained { get; set; }

    public int? LnrBonusesSpent { get; set; }
}
