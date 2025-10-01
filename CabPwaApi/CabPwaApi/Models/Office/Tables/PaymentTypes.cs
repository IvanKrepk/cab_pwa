using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class PaymentTypes
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [StringLength(64)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("isActive")]
    public short IsActive { get; set; }

    [Column("isByExternalCard")]
    public short IsByExternalCard { get; set; }

    public double BankCommission { get; set; }
}
