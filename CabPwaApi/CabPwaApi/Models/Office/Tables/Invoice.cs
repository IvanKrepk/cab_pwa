using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Invoice
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int Number { get; set; }

    public DateOnly InvoiceDate { get; set; }

    public int ClientCode { get; set; }

    public byte InvoiceType { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string InvoiceSubject { get; set; } = null!;

    [Column("VATpercent")]
    public int Vatpercent { get; set; }

    public double InvoiceSum { get; set; }

    public byte IsPaid { get; set; }

    public DateOnly? PaidDate { get; set; }

    [InverseProperty("Invoice")]
    public virtual ICollection<InvoiceDetail> InvoiceDetail { get; set; } = new List<InvoiceDetail>();
}
