using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VFuelProviders
{
    [StringLength(64)]
    [Unicode(false)]
    public string ProviderName { get; set; } = null!;

    [StringLength(64)]
    [Unicode(false)]
    public string? FullName { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string? BankAccount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Bank { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? CorrAccount { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CorrBank { get; set; }

    [Column("INN")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Inn { get; set; }

    [Column("OKPO")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Okpo { get; set; }

    [Column("OKONH")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Okonh { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? Phones { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? ContactFace { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNumber { get; set; }

    [Column("props")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Props { get; set; }

    [Column("KPP")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Kpp { get; set; }

    public short ProviderCode { get; set; }

    public short Active { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public short? IsFuelProvider { get; set; }

    public short? IsWareProvider { get; set; }

    public int? Credit { get; set; }

    public int? Uprochenka { get; set; }

    [Column("ContractorID")]
    public int? ContractorId { get; set; }

    public byte IsImporter { get; set; }
}
