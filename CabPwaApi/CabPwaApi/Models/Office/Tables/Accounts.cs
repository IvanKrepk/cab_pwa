using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("CardNumber", Name = "IX_AccountsByCardNumber")]
[Index("AccountName", Name = "IX_AccountsByName")]
public partial class Accounts
{
    [Key]
    public int AccountNumber { get; set; }

    public short ClientCode { get; set; }

    public int Version { get; set; }

    public short Closed { get; set; }

    public short AccountType { get; set; }

    [Column("AfsID")]
    public short? AfsId { get; set; }

    public short ProductCode { get; set; }

    public double? AdditionQuantity { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AccountOpenDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AccountExpireDate { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? AccountName { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? CarName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? CarNumber { get; set; }

    public double? Credit { get; set; }

    public double? Discount { get; set; }

    public double? Rest { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RestUpdateTime { get; set; }

    public short InStopList { get; set; }

    public int? CardNumber { get; set; }

    public short? CardVer { get; set; }

    public double? MinRest { get; set; }

    public int? PinCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastCardTransTime { get; set; }

    [Column("LastCardTransID")]
    public int? LastCardTransId { get; set; }

    public double? UnreturnedRest { get; set; }

    public short? CardType { get; set; }

    public double? DailyDebitLimit { get; set; }

    public double? DailyPurseLimit { get; set; }

    public int? CardGraphNumber { get; set; }

    public int? CardEmitentCode { get; set; }

    public short? CardHasBonusPurse { get; set; }

    public int? BonusCardCategory { get; set; }

    public short? CardHasNoPurse { get; set; }

    public int? BonusSaleType { get; set; }

    public byte? IsVehicleAccount { get; set; }

    [Column("ExternalID")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ExternalId { get; set; }

    public int? ExtraBonuses { get; set; }

    [Column("VW_Mileage")]
    public int? VwMileage { get; set; }

    [Column("VW_MVZ")]
    public long? VwMvz { get; set; }

    [Column("VW_Departament")]
    [StringLength(50)]
    [Unicode(false)]
    public string? VwDepartament { get; set; }

    public byte CardIsVirtual { get; set; }

    [InverseProperty("AccountNumberNavigation")]
    public virtual AccountOwners? AccountOwners { get; set; }

    [InverseProperty("AccountNumberNavigation")]
    public virtual ICollection<CardHistory> CardHistory { get; set; } = new List<CardHistory>();

    [InverseProperty("AccountNumberNavigation")]
    public virtual Vcards? Vcards { get; set; }

    [ForeignKey("AccountNumber")]
    [InverseProperty("AccountNumber")]
    public virtual ICollection<WebAccessLogins> Id { get; set; } = new List<WebAccessLogins>();

    [ForeignKey("AccountNumber")]
    [InverseProperty("AccountNumber")]
    public virtual ICollection<Tags> Tag { get; set; } = new List<Tags>();
}
