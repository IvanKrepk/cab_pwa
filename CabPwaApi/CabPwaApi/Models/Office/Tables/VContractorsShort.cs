using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VContractorsShort
{
    [StringLength(64)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? Phones { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? ContactFace { get; set; }

    [Column("INN")]
    [StringLength(12)]
    [Unicode(false)]
    public string? Inn { get; set; }

    [Column("ID")]
    public int Id { get; set; }
}
