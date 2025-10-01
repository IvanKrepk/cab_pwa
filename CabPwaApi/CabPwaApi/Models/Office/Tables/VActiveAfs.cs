using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VActiveAfs
{
    public short AfsId { get; set; }

    public int ConfigVersion { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string AdminPassword { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string UserPassword { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string AfsName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Phone { get; set; }

    public short PumpControllerType { get; set; }

    public short PumpControllerComNumber { get; set; }

    public short PumpControllerComChannel { get; set; }

    public short EcrType { get; set; }

    public short RetCheckType { get; set; }

    public short EcrComNumber { get; set; }

    public short EcrComChannel { get; set; }

    public short LmType { get; set; }

    public short LmComNumber { get; set; }

    public short LmComChannel { get; set; }

    public short ModemType { get; set; }

    public int ModemTermSpeed { get; set; }

    public short ModemComNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModemInitString { get; set; }

    public short ShopEnabled { get; set; }

    public short SeparateWindowsForNozzles { get; set; }

    public short MaxDozeDigits { get; set; }

    public short EnableCouponPayment { get; set; }

    public double? LastSessionTime { get; set; }

    public double DataReceiveingInterval { get; set; }

    public double? LastRecordTime { get; set; }

    public short InterRelayOperation { get; set; }

    public int CalTablesVersion { get; set; }

    [Column("LastRID")]
    public int? LastRid { get; set; }

    [Column("KeyID")]
    public int? KeyId { get; set; }

    public int? TradeObjectType { get; set; }

    public int? FuelInvSchedVer { get; set; }

    public int? TankParamsVer { get; set; }

    public short? ForceConfigResync { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? TankMeasureTimes { get; set; }

    [Column("VerRecID")]
    public int? VerRecId { get; set; }

    public int? WareListVersion { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? CheckAdvertisingText { get; set; }

    [Column("CombineGroupID")]
    public int CombineGroupId { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? CombineGroupName { get; set; }

    public byte InActive { get; set; }
}
