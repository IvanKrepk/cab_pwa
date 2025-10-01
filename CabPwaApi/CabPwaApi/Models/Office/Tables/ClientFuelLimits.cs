using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ClientCode", "ProductCode")]
public partial class ClientFuelLimits
{
    [Key]
    public int ClientCode { get; set; }

    [Key]
    public int ProductCode { get; set; }

    [Column("GID")]
    [StringLength(36)]
    [Unicode(false)]
    public string Gid { get; set; } = null!;

    public int Qty { get; set; }

    public DateOnly? ExpirationDate { get; set; }
}
