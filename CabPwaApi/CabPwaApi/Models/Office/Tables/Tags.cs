using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Tags
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? Note { get; set; }

    /// <summary>
    /// Код клиент, внутри которого действуют данные тэги, назначаются на счета
    /// </summary>
    public int? ClientCode { get; set; }

    [ForeignKey("TagId")]
    [InverseProperty("Tag")]
    public virtual ICollection<Accounts> AccountNumber { get; set; } = new List<Accounts>();

    [ForeignKey("TagId")]
    [InverseProperty("Tag")]
    public virtual ICollection<Clients> ClientCodeNavigation { get; set; } = new List<Clients>();
}
