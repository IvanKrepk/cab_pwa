using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("ClientCode", "ProductCode", Name = "AK_Client_Product", IsUnique = true)]
public partial class BalanceByClientsPurses
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public short ClientCode { get; set; }

    [Column("ProductCOde")]
    public int ProductCode { get; set; }

    public double Balance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BalanceUpdateTime { get; set; }

    public double CreditDepth { get; set; }

    public byte InStopList { get; set; }

    public short? InStopListReason { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? InStopListReasonDesc { get; set; }

    public int? SignalBalance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InStopListDate { get; set; }

    [ForeignKey("ClientCode")]
    [InverseProperty("BalanceByClientsPurses")]
    public virtual Clients ClientCodeNavigation { get; set; } = null!;
}
