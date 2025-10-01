using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class RevaluationDocs
{
    [Key]
    [Column("DocID")]
    public int DocId { get; set; }

    [Column("GroupID")]
    public int GroupId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfBeg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("DefaultNDS")]
    public double? DefaultNds { get; set; }

    public double? DefaultCharge { get; set; }

    public int? Version { get; set; }

    public short? AlwaysSet { get; set; }

    public byte IsDraft { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Note { get; set; }
}
