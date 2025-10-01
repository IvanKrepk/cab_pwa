using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("VCards")]
public partial class Vcards
{
    [Key]
    public int AccountNumber { get; set; }

    [MaxLength(1024)]
    public byte[]? BinImage { get; set; }

    public string? JsonImage { get; set; }

    public int UpdateCount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UpdatedAt { get; set; }

    [ForeignKey("AccountNumber")]
    [InverseProperty("Vcards")]
    public virtual Accounts AccountNumberNavigation { get; set; } = null!;
}
