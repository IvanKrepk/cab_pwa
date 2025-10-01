using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("CompletedAt", Name = "IxFuelWholesalesByCompletionTime")]
public partial class FuelWholesales
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GID")]
    [StringLength(36)]
    [Unicode(false)]
    public string Gid { get; set; } = null!;

    [Column("AccountingOperatorID")]
    public int AccountingOperatorId { get; set; }

    [Column("OperatorID")]
    public int? OperatorId { get; set; }

    public int ProviderCode { get; set; }

    public int ClientCode { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public int TradeObj { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    public short FromHold { get; set; }

    public int? CargoSenderCode { get; set; }

    public int CargoReceiverCode { get; set; }

    public int? TransporterCode { get; set; }

    [Column("LoadingPointID")]
    public int? LoadingPointId { get; set; }

    [Column("UnloadingPointID")]
    public int? UnloadingPointId { get; set; }

    [Column("FuelDriverID")]
    public int FuelDriverId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Waybill { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PassNumber { get; set; }

    [Column("TruckID")]
    public int TruckId { get; set; }

    [Column("TrailerID")]
    public int? TrailerId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? WarrantyNumber { get; set; }

    public DateOnly? WarrantyDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? WarrantyIssuer { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Forwarder { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? QualityPassportNumber { get; set; }

    public DateOnly? QualityPassportDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Transporter { get; set; }

    public int? TransferredFromCode { get; set; }

    public int? CargoRequesterCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CargoRequester { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public int Status { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CompletedAt { get; set; }
}
