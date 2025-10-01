using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Globals
{
    [Key]
    [Column("pkey")]
    public int Pkey { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string OrganizationName { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? Phone { get; set; }

    public int? LogKeepingTime { get; set; }

    public int AfsListVersion { get; set; }

    public int OperatorsVersion { get; set; }

    public int ProductsVersion { get; set; }

    public int CouponsVersion { get; set; }

    public int ProvidersVersion { get; set; }

    public int CardStopListVersion { get; set; }

    public int AccountsVersion { get; set; }

    public int? InternalCouponCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastImportTime { get; set; }

    public int? NextAccountNumber { get; set; }

    public int? OrganizationCode { get; set; }

    public int? WaresVersion { get; set; }

    public int? DeletedItemVersion { get; set; }

    public int? FuelDriversVersion { get; set; }

    public int? TankTrucksVersion { get; set; }

    public int? ProdDscVersion { get; set; }

    public int? GivenCouponsVersion { get; set; }

    public int? PaymentTypesVersion { get; set; }

    [Column("CurrentDBVersion")]
    public int? CurrentDbversion { get; set; }

    [Column("MinDBVersion")]
    public int? MinDbversion { get; set; }

    public short? RecordFuelSells { get; set; }

    public int? ActLimitsVersion { get; set; }

    public int? DelayedCardAddVersion { get; set; }

    public int? AfsGroupsVersion { get; set; }

    public int? BonusSchemVersion { get; set; }

    public int? DiscountSchemVersion { get; set; }

    public int? BonusCardCategoryVersion { get; set; }

    public int? DelayedBonusAddVersion { get; set; }

    public int? RevaluationDocsVersion { get; set; }

    public int? DcrVersion { get; set; }

    [Column("EMail")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? Director { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? Accountant { get; set; }

    public int? ContractorsVersion { get; set; }

    public int? ManufacturersVersion { get; set; }

    public byte? ImpactCouponsOnBalanceClient { get; set; }

    [Column("SMSNoticeEnable")]
    public byte SmsnoticeEnable { get; set; }

    [Column("SMSProviderLogin")]
    [StringLength(30)]
    [Unicode(false)]
    public string SmsproviderLogin { get; set; } = null!;

    [Column("SMSProviderPassword")]
    [StringLength(30)]
    [Unicode(false)]
    public string SmsproviderPassword { get; set; } = null!;

    [Column("SMSBonusMsgTemplate")]
    [StringLength(500)]
    [Unicode(false)]
    public string SmsbonusMsgTemplate { get; set; } = null!;

    [Column("SMSCounter")]
    public long Smscounter { get; set; }

    [Column("AdminPhoneForSMS")]
    [StringLength(15)]
    [Unicode(false)]
    public string? AdminPhoneForSms { get; set; }

    [Column("AdminSMSNExtTime", TypeName = "datetime")]
    public DateTime AdminSmsnextTime { get; set; }

    [Column("LastAFSControlHash")]
    [StringLength(16)]
    [Unicode(false)]
    public string LastAfscontrolHash { get; set; } = null!;

    [Column("CheckBalanceOnAFS")]
    public byte CheckBalanceOnAfs { get; set; }

    public byte CheckWareInfoLoading { get; set; }

    [Column("NextFwsID")]
    public int? NextFwsId { get; set; }

    [Column("SMSSenderName")]
    [StringLength(30)]
    [Unicode(false)]
    public string? SmssenderName { get; set; }

    [Column("SSTRepaidVersion")]
    public int? SstrepaidVersion { get; set; }

    [Column("CardAccountsOwnerOnAFS")]
    public byte CardAccountsOwnerOnAfs { get; set; }

    [Column("VCardEmitentCode")]
    public int? VcardEmitentCode { get; set; }

    [Column("VCardBonusCardCategory")]
    public int? VcardBonusCardCategory { get; set; }

    public byte WebServerUsersRefreshNeed { get; set; }
}
