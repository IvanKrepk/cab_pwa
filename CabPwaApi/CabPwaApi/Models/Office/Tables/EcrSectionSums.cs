using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "Wsid", "EcrId", "SectionNumber")]
public partial class EcrSectionSums
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    [Column("WSID")]
    public int Wsid { get; set; }

    [Key]
    [Column("EcrID")]
    public int EcrId { get; set; }

    [Key]
    public int SectionNumber { get; set; }

    public double SectionSum { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }
}
