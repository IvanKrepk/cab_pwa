using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CurRelays
{
    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }

    public double DataUpdateTime { get; set; }

    public short InProgress { get; set; }

    [Column("FirstOperatorID")]
    public short? FirstOperatorId { get; set; }

    [Column("SecondOperatorID")]
    public short? SecondOperatorId { get; set; }

    [Column("ThirdOperatorID")]
    public short? ThirdOperatorId { get; set; }

    public double OpenTime { get; set; }

    public double? CloseTime { get; set; }

    public double? InitialCashRemainder { get; set; }

    public double? Cash { get; set; }

    public double? InternalCollection { get; set; }

    public double? CashToBank { get; set; }

    public double? FinalCashRemainder { get; set; }

    public double? OverflowCost { get; set; }

    public double? CardCreditSum { get; set; }
}
