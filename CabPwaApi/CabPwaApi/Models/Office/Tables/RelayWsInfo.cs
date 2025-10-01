using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "Wsid", "SubNo")]
public partial class RelayWsInfo
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("WSID")]
    public int Wsid { get; set; }

    [Key]
    public int SubNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OpenedAt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ClosedAt { get; set; }

    public double? InitialCashRemainder { get; set; }

    public double? CardCreditSum { get; set; }

    public double? Cash { get; set; }

    public double? OtherIncoming { get; set; }

    public double? CashToBank { get; set; }

    public double? InternalCollection { get; set; }

    public double? FinalCashRemainder { get; set; }

    [Column("ZReportSum")]
    public double? ZreportSum { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? EcrSerialNumber { get; set; }

    [Column("ZReportNumber")]
    public int? ZreportNumber { get; set; }

    [Column("ZReportDateTime", TypeName = "datetime")]
    public DateTime? ZreportDateTime { get; set; }
}
