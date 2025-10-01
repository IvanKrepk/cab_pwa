using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "WareCode")]
public partial class TradeObjectWares
{
    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    [Key]
    public int WareCode { get; set; }
}
