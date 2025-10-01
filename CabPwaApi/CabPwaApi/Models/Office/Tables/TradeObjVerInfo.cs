using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class TradeObjVerInfo
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    [Column("AfsID")]
    public int? AfsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecTime { get; set; }

    public int? OperatorsVersion { get; set; }

    public int? CouponsVersion { get; set; }

    public int? ProvidersVersion { get; set; }

    public int? CardStopListVersion { get; set; }

    public int? CalTablesVersion { get; set; }

    public int? AccountsVersion { get; set; }

    public int? WaresVersion { get; set; }

    public int? DeletedItemVersion { get; set; }

    public int? FuelDriversVersion { get; set; }

    public int? TankTrucksVersion { get; set; }

    public int? ProdDscVersion { get; set; }

    public int? AfsListVersion { get; set; }

    public int? GivenCouponsVersion { get; set; }

    public int? FuelInvSchedVersion { get; set; }

    public int? TankParamsVersion { get; set; }

    public int? ActLimitsVersion { get; set; }

    public int? ProductsVersion { get; set; }

    public int? CfgFormatVersion { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? AppVersion { get; set; }

    public int? AppKeyType { get; set; }

    public int? AppKeyNumber { get; set; }

    public int? AppKeySerial { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? KeyFlags { get; set; }

    public int? AppFlags1 { get; set; }

    public int? AppFlags2 { get; set; }

    public int? AppFlags3 { get; set; }

    public int? AppFlags4 { get; set; }

    public int? AppFlags5 { get; set; }

    public int? AppFlags6 { get; set; }

    public int? AppFlags7 { get; set; }

    public int? AppFlags8 { get; set; }

    public int? DelayedCardAddVersion { get; set; }

    public int? WareListVersion { get; set; }

    public int? AfsGroupsVersion { get; set; }

    public int? BonusSchemVersion { get; set; }

    public int? DiscountSchemVersion { get; set; }

    public int? BonusCardCategoryVersion { get; set; }

    public int? DelayedBonusAddVersion { get; set; }

    public int? RevaluationDocsVersion { get; set; }

    public short? KeyManufacturer { get; set; }

    public int? TankBookRemainderOffsetsVersion { get; set; }

    public int? ContractorsVersion { get; set; }

    public int? ManufacturersVersion { get; set; }

    public int? AppFlags9 { get; set; }

    public int? AppFlags10 { get; set; }

    public int? AppFlags11 { get; set; }

    public int? AppFlags12 { get; set; }

    public int? AppFlags13 { get; set; }

    public int? AppFlags14 { get; set; }

    public int? AppFlags15 { get; set; }

    public int? AppFlags16 { get; set; }

    [Column("SSTRepaidVersion")]
    public int? SstrepaidVersion { get; set; }
}
