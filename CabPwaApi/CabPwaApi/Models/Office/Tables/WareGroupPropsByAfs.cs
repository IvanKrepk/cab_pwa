using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("WareGroupPropsByAFS")]
[Index("GroupCode", "Afsid", Name = "IX_WareGroupsPropsByAFS_WareCode_AFSID", IsUnique = true)]
public partial class WareGroupPropsByAfs
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int GroupCode { get; set; }

    [Column("AFSID")]
    public int Afsid { get; set; }

    public byte TaxSystem { get; set; }
}
