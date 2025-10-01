using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("AccountNumber", Name = "Uq_BonusInformForAccounts", IsUnique = true)]
public partial class BonusInformForAccounts
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int AccountNumber { get; set; }

    public int? TotalBonuses { get; set; }

    public int? PrevMonthBonuses { get; set; }

    public int? CurMonthBonuses { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BonusUpdateTime { get; set; }

    public int IsWriteOff { get; set; }
}
