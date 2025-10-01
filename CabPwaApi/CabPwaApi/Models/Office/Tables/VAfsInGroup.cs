using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VAfsInGroup
{
    [Column("AfsID")]
    public short AfsId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AfsName { get; set; } = null!;

    [Column("GroupID")]
    public int GroupId { get; set; }

    public int? TradeObjectType { get; set; }

    [Column("CombineGroupID")]
    public int CombineGroupId { get; set; }

    public byte InActive { get; set; }
}
