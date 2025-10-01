using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VAfsOutGroup
{
    public short AfsId { get; set; }

    [Column("AFSName")]
    [StringLength(50)]
    [Unicode(false)]
    public string Afsname { get; set; } = null!;

    public int? TradeObjectType { get; set; }

    [Column("GroupID")]
    public int GroupId { get; set; }

    [Column("CombineGroupID")]
    public int CombineGroupId { get; set; }

    public byte InActive { get; set; }
}
