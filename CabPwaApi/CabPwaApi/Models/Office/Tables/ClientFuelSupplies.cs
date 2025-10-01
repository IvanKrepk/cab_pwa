using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class ClientFuelSupplies
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GID")]
    [StringLength(36)]
    [Unicode(false)]
    public string Gid { get; set; } = null!;

    public int SupplyType { get; set; }

    public int Flags { get; set; }

    [Column("AccountingOperatorID")]
    public int AccountingOperatorId { get; set; }

    public int ProviderCode { get; set; }

    public int FirmCode { get; set; }

    public int ClientCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SupplyDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
