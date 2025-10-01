using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("WebLogin", Name = "AK_LOGINKEY_WEBACCES", IsUnique = true)]
public partial class WebAccessLogins
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public short ClientCode { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string WebLogin { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string PassHash { get; set; } = null!;

    public short IsActive { get; set; }

    public short AllAccounts { get; set; }

    [ForeignKey("ClientCode")]
    [InverseProperty("WebAccessLogins")]
    public virtual Clients ClientCodeNavigation { get; set; } = null!;

    [ForeignKey("Id")]
    [InverseProperty("Id")]
    public virtual ICollection<Accounts> AccountNumber { get; set; } = new List<Accounts>();
}
