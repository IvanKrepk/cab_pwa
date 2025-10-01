using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("AccountNumber", Name = "IX_DelayedCardAddsByAcc")]
[Index("Version", Name = "IX_DelayedCardAddsByVer")]
public partial class DelayedCardAdditions
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    public int AccountNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AddedAt { get; set; }

    public int Version { get; set; }

    public int PurseContentCode { get; set; }

    public int AddQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PerformedAt { get; set; }

    public int? PerformedOn { get; set; }

    public double? AddFloatQty { get; set; }

    public short? IsUnreturnedRest { get; set; }

    public byte IsTransfer { get; set; }

    public int? InteractAccount { get; set; }

    public int? CreatedOn { get; set; }
}
