using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "TankNo", "H")]
public partial class CalTables
{
    [Key]
    [Column("AfsID")]
    public short AfsId { get; set; }

    [Key]
    public short TankNo { get; set; }

    [Key]
    public double H { get; set; }

    public double V { get; set; }
}
