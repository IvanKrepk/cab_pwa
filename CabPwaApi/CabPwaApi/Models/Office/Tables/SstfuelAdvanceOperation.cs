using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("SSTFuelAdvanceOperation")]
[Index("ReceiptId", Name = "UK_FuelAdvance_ReceiptID", IsUnique = true)]
public partial class SstfuelAdvanceOperation
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("AFSID")]
    public int Afsid { get; set; }

    public byte Operation { get; set; }

    public int UpdateCount { get; set; }

    public double OperationSum { get; set; }

    [Column("ReceiptID")]
    [StringLength(50)]
    [Unicode(false)]
    public string ReceiptId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Created { get; set; }

    public byte Kind { get; set; }

    [Column("InitialAFSID")]
    public int InitialAfsid { get; set; }

    public double InitialSum { get; set; }

    public double Remains { get; set; }

    public DateOnly Expires { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RepaidDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? RepaidNote { get; set; }

    public int? Version { get; set; }
}
