using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class FuelWholesaleQueue
{
    [Key]
    [Column("FuelWholesaleID")]
    public int FuelWholesaleId { get; set; }

    [Column("TradeObjID")]
    public int TradeObjId { get; set; }
}
