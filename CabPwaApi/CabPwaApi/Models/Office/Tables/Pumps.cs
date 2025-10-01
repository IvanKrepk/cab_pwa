using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "PumpNo")]
public partial class Pumps
{
    [Key]
    public short AfsId { get; set; }

    [Key]
    public short PumpNo { get; set; }

    public short PhysAddr { get; set; }

    public short NozzleNo { get; set; }

    public short TankNo { get; set; }

    public short? SecondaryTankNo { get; set; }

    public short InLiters { get; set; }

    public short EcrSection { get; set; }

    public int? CounterDigits { get; set; }
}
