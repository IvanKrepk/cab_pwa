using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Operators
{
    [Key]
    public short OperatorCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OperatorName { get; set; } = null!;

    public short Active { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? TableNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? HireDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DismissalDate { get; set; }

    [Column("JobID")]
    public int? JobId { get; set; }

    [Column("IButtonID")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IbuttonId { get; set; }

    [Column("INN")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Inn { get; set; }
}
