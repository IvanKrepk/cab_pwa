using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class WareUnits
{
    [Key]
    public int Code { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [StringLength(32)]
    [Unicode(false)]
    public string? Description { get; set; }

    public int? Version { get; set; }

    public short IsPiece { get; set; }
}
