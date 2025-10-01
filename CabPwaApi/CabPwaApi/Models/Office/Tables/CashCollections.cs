using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Rid", "OpOrder")]
public partial class CashCollections
{
    [Key]
    [Column("RID")]
    public int Rid { get; set; }

    [Key]
    public int OpOrder { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    [Column("WSID")]
    public int Wsid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OpTime { get; set; }

    public double CollectedSum { get; set; }

    public short CollectionType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? BagNumber { get; set; }
}
