using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "SellId")]
public partial class FuelSell
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("SellID")]
    public int SellId { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    [Column("WSID")]
    public short Wsid { get; set; }

    public int TankNo { get; set; }

    public int PumpNo { get; set; }

    public int ProductCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EndTime { get; set; }

    public int PaymentType { get; set; }

    public int RequestType { get; set; }

    public double? RequestQty { get; set; }

    public double? RequestSum { get; set; }

    public double UndiscountedPrice { get; set; }

    public int DiscountType { get; set; }

    public double DiscountValue { get; set; }

    public double SoldQty { get; set; }

    public double RetailCost { get; set; }

    public double? Density { get; set; }

    public double? NormalizedDensity { get; set; }

    public double? NormalizedQty { get; set; }

    public int? LmStartLevel { get; set; }

    public double? LmStartVolume { get; set; }

    public int? LmEndLevel { get; set; }

    public double? LmEndVolume { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? CardNumber { get; set; }

    [Column("BonusChargeSchemaID")]
    public int? BonusChargeSchemaId { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? BonusCardNumber { get; set; }

    public int? AccountNumber { get; set; }

    public int? SecondAccountNumber { get; set; }

    [Column("SBCardTransID")]
    public int? SbcardTransId { get; set; }

    [Column("LnrCardTypeID")]
    public int? LnrCardTypeId { get; set; }

    public int? PaymentInfo { get; set; }

    [Column("CashierID")]
    public int? CashierId { get; set; }

    public byte? IsRealOutput { get; set; }

    [Column("EventGroupID")]
    public long? EventGroupId { get; set; }
}
