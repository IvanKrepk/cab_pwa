using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class InvoiceDetail
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("InvoiceID")]
    public int InvoiceId { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string DetailText { get; set; } = null!;

    public double Quantity { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AddField1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AddField2 { get; set; }

    public double Price { get; set; }

    [Column("VAT")]
    public double Vat { get; set; }

    public double DetailSum { get; set; }

    [ForeignKey("InvoiceId")]
    [InverseProperty("InvoiceDetail")]
    public virtual Invoice Invoice { get; set; } = null!;
}
