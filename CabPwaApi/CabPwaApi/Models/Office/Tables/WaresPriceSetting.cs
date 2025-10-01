using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class WaresPriceSetting
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("DocID")]
    public int DocId { get; set; }

    public int WareCode { get; set; }

    public double? LastReceivingPrice { get; set; }

    [Column("NDS")]
    public double? Nds { get; set; }

    public double? Charge { get; set; }

    public double? RetailPrice { get; set; }
}
