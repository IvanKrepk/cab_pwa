using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class BonusTrans
{
    [Key]
    public long TransTime { get; set; }

    public int ClientCode { get; set; }

    public int AccountNumber { get; set; }

    public short? OperationType { get; set; }

    [Column("AfsID")]
    public int? AfsId { get; set; }

    public int? BonusDelta { get; set; }

    public int? TotalBonuses { get; set; }

    public int? ProductCode { get; set; }

    public short? PumpNo { get; set; }

    [Column("CardID")]
    public int? CardId { get; set; }

    public int? EmitentCode { get; set; }

    public int? CardNumber { get; set; }

    public int? LastMonthBonuses { get; set; }

    public int? ThisMonthBonuses { get; set; }

    [Column("BonusSchemaID")]
    public int? BonusSchemaId { get; set; }

    public int? PurseContentCode { get; set; }

    public int? PaymentType { get; set; }

    public double? Qty { get; set; }

    public double? Cost { get; set; }

    public double? RetailPrice { get; set; }

    public int? TankNo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? WareCodes { get; set; }

    public int? AddedBonuses { get; set; }

    public int? RemovedBonuses { get; set; }

    public byte? ByCash { get; set; }

    [Column("BonusAddShemaID")]
    public int? BonusAddShemaId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransDateTime { get; set; }

    public short DiscountType { get; set; }

    public double Discount { get; set; }

    public double? DiscountCost { get; set; }
}
