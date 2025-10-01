using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("CorrectionTime", Name = "IxClientFuelRemainderCorrectionsByTime")]
public partial class ClientFuelRemainderCorrections
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GID")]
    [StringLength(36)]
    [Unicode(false)]
    public string Gid { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CorrectionTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationTime { get; set; }

    [Column("AccountingOperatorID")]
    public int AccountingOperatorId { get; set; }

    public int FirmCode { get; set; }

    public int ClientCode { get; set; }

    public int CorrectionType { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
