using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("Afsid", Name = "WareSellChecks_idx")]
public partial class WareSellChecks
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("AFSID")]
    public int Afsid { get; set; }

    [Column("RID")]
    public int Rid { get; set; }

    [Column("WSID")]
    public int Wsid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CheckDate { get; set; }

    public double TotalSumWithoutDiscount { get; set; }

    public double TotalSum { get; set; }

    public byte IsReturn { get; set; }

    [Column("SBCardTransID")]
    public int? SbcardTransId { get; set; }

    [Column("CashierID")]
    public int? CashierId { get; set; }
}
