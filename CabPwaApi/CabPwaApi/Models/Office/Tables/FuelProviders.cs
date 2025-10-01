using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class FuelProviders
{
    [Key]
    public short ProviderCode { get; set; }

    public short Active { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProviderName { get; set; } = null!;

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

    [ForeignKey("ContractorId")]
    [InverseProperty("FuelProviders")]
    public virtual Contractors? Contractor { get; set; }
}
