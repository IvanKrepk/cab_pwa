using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "PersId")]
public partial class WorkTime
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("PersID")]
    public int PersId { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    public int? WorkTimeMinutes { get; set; }
}
