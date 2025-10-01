using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("PaymentDate", Name = "IxClientFuelPaymentsByDate")]
public partial class ClientFuelPayments
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

    [Column(TypeName = "datetime")]
    public DateTime CreationDate { get; set; }

    public int ClientCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PaymentDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
