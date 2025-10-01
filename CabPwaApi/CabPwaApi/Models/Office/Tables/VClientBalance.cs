using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VClientBalance
{
    public short ClientCode { get; set; }

    public int ProductCode { get; set; }

    public double Balance { get; set; }

    public double CurrentBalance { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BalanceUpdateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CurrentBalanceUpdateTime { get; set; }

    [Column("ClientsPurseNAme")]
    [StringLength(10)]
    [Unicode(false)]
    public string ClientsPurseName { get; set; } = null!;

    public double CreditDepth { get; set; }
}
