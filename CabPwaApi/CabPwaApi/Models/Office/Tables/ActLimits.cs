using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("AccountNumber", Name = "IX_ActLimitsByAccount")]
[Index("Version", Name = "IX_ActLimitsByVersion")]
public partial class ActLimits
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    public int AccountNumber { get; set; }

    public int ProductCode { get; set; }

    public short LimitType { get; set; }

    public int LimitValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    public int Version { get; set; }
}
