using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CancelledFuelWholesales
{
    [Key]
    [Column("FuelWholesaleID")]
    public int FuelWholesaleId { get; set; }
}
