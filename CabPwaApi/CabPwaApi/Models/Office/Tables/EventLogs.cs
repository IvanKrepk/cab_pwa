using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("TradeObjectId", "DsId", "EvtLogCrc", Name = "IX_EventLogsByTradeObjectAndCRC")]
public partial class EventLogs
{
    [Key]
    [Column("EvtLogID")]
    public int EvtLogId { get; set; }

    [Column("TradeObjectID")]
    public int TradeObjectId { get; set; }

    [Column("DsID")]
    public int DsId { get; set; }

    public int DsVersion { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreationTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ImportTime { get; set; }

    public short IsCorrupted { get; set; }

    [Column(TypeName = "image")]
    public byte[]? EvtData { get; set; }

    [Column("EvtLogCRC")]
    public int? EvtLogCrc { get; set; }
}
