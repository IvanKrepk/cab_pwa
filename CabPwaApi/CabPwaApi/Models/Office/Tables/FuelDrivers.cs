using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class FuelDrivers
{
    [Key]
    public int FdrvCode { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string FdrvName { get; set; } = null!;

    public short Working { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? Notes { get; set; }

    public int? Version { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DocSeries { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    public DateOnly? DocIssueDate { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? DocIssuer { get; set; }
}
