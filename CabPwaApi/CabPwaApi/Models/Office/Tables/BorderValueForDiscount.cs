using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class BorderValueForDiscount
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int TableId { get; set; }

    public int Border { get; set; }

    public double Discount { get; set; }
}
