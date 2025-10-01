using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("AfsId", Name = "IX_RelaysByAfs")]
[Index("CloseTime", Name = "IX_RelaysByCloseTime")]
[Index("OpenDateTime", Name = "IX_RelaysByOpenDateTime")]
[Index("OpenTime", Name = "IX_RelaysByOpenTime")]
public partial class Relays
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Column("AfsID")]
    public short AfsId { get; set; }

    [Column("ReceivedRelayID")]
    public int? ReceivedRelayId { get; set; }

    public short InProgress { get; set; }

    [Column("FirstOperatorID")]
    public short? FirstOperatorId { get; set; }

    [Column("SecondOperatorID")]
    public short? SecondOperatorId { get; set; }

    [Column("ThirdOperatorID")]
    public short? ThirdOperatorId { get; set; }

    public double OpenTime { get; set; }

    public double? CloseTime { get; set; }

    public double? InitialCashRemainder { get; set; }

    public double? Cash { get; set; }

    public double? Salary { get; set; }

    public double? ManagmentNeed { get; set; }

    public double? InternalCollection { get; set; }

    public double? CashToBank { get; set; }

    public double? FinalCashRemainder { get; set; }

    public short StartedNormally { get; set; }

    public short EndedNormally { get; set; }

    public short SomeDataLost { get; set; }

    public short StatsIncomplete { get; set; }

    public double? OverflowCost { get; set; }

    public double? CardCreditSum { get; set; }

    public double? PaidOverflowsSum { get; set; }

    [Column("ZReportSum")]
    public double? ZreportSum { get; set; }

    public int? RelayOrder { get; set; }

    public int? ReportImageFormat { get; set; }

    [Column(TypeName = "image")]
    public byte[]? ReportImage { get; set; }

    [Column("downloaded_via_afsaccess")]
    public short? DownloadedViaAfsaccess { get; set; }

    [Column("EvtLogID")]
    public int? EvtLogId { get; set; }

    public int? LostDataTypes { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OpenDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CloseDateTime { get; set; }
}
