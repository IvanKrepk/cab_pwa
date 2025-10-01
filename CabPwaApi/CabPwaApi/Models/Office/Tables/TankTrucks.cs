using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class TankTrucks
{
    [Key]
    public int TtCode { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string TtName { get; set; } = null!;

    public int? CalibratedVol { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public int? Version { get; set; }

    public double? RelMsrError { get; set; }

    public int? OrificeDiameter { get; set; }

    public short? IsTrailer { get; set; }

    public int? SectionCount { get; set; }

    public byte? IsActive { get; set; }

    [Column("ContractorOwnerID")]
    public int? ContractorOwnerId { get; set; }

    public int? OrificeType { get; set; }

    public int? OrificeWidth { get; set; }

    public int? OrificeHeight { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Model { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CbrCertNumber { get; set; }

    public DateOnly? CbrCertExpireDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? LicenseNumber { get; set; }

    public DateOnly? LicenseExpireDate { get; set; }

    public int? Section1Vol { get; set; }

    public int? Section2Vol { get; set; }

    public int? Section2OrificeDiameter { get; set; }

    public int? Section3Vol { get; set; }

    public int? Section3OrificeDiameter { get; set; }

    public int? Section4Vol { get; set; }

    public int? Section4OrificeDiameter { get; set; }

    public int? Section5Vol { get; set; }

    public int? Section5OrificeDiameter { get; set; }

    public int? Section6Vol { get; set; }

    public int? Section6OrificeDiameter { get; set; }
}
