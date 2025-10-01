using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class AccountOwners
{
    [Key]
    public int AccountNumber { get; set; }

    [StringLength(80)]
    [Unicode(false)]
    public string OwnerName { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string DocType { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DocNumber { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [StringLength(230)]
    [Unicode(false)]
    public string? DocGiven { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Phone { get; set; }

    [Column("EMail")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [StringLength(230)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(230)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [StringLength(230)]
    [Unicode(false)]
    public string? ExtraNotes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RegistrationDate { get; set; }

    [Column("SMSNotice")]
    public int Smsnotice { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? MiddleName { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? LastName { get; set; }

    public short Sex { get; set; }

    [Column("SMSTemplateList")]
    [StringLength(30)]
    [Unicode(false)]
    public string? SmstemplateList { get; set; }

    [ForeignKey("AccountNumber")]
    [InverseProperty("AccountOwners")]
    public virtual Accounts AccountNumberNavigation { get; set; } = null!;
}
