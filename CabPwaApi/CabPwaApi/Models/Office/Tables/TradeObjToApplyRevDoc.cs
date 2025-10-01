using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("Guid", Name = "IX_TradeObjToApplyRevDocByGUID")]
public partial class TradeObjToApplyRevDoc
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DocID")]
    public int DocId { get; set; }

    [Column("TradeID")]
    public int TradeId { get; set; }

    [Column("GUID")]
    [StringLength(16)]
    [Unicode(false)]
    public string? Guid { get; set; }

    public short? WasSet { get; set; }
}
