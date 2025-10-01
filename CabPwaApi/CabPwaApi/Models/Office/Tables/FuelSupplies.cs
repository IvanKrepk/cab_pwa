using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class FuelSupplies
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GID")]
    [StringLength(36)]
    [Unicode(false)]
    public string Gid { get; set; } = null!;

    public int SupplyType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    public DateOnly? ShipmentDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SupplyDate { get; set; }

    [Column("ObjectID")]
    public int ObjectId { get; set; }

    [Column("AccountingOperatorID")]
    public int AccountingOperatorId { get; set; }

    [Column("OperatorID")]
    public int OperatorId { get; set; }

    public int FirmCode { get; set; }

    public int ProviderClientCode { get; set; }

    public int CargoSenderCode { get; set; }

    [Column("LoadingPointID")]
    public int LoadingPointId { get; set; }

    public int CargoReceiverCode { get; set; }

    [Column("UnloadingPointID")]
    public int UnloadingPointId { get; set; }

    public int ClientCode { get; set; }

    public int MeasurementMethod { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DensityMeterNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LevelMeterNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column("OwnStaffID1")]
    public int? OwnStaffId1 { get; set; }

    [Column("OwnStaffID2")]
    public int? OwnStaffId2 { get; set; }

    [Column("OwnStaffID3")]
    public int? OwnStaffId3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CustomerRepresentative { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? CustRepLicenseNum { get; set; }

    public DateOnly? CustRepLicenseDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PublicRepresentative { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PublicRepLicenseNum { get; set; }

    public DateOnly? PublicRepLicenseDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? PubRepCommiteeDocNum { get; set; }

    public DateOnly? PubRepCommiteeDocDate { get; set; }
}
