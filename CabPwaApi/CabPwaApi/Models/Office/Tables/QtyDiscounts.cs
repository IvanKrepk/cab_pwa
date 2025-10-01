using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class QtyDiscounts
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    public int ProductCode { get; set; }

    public int StartQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public short DiscountType { get; set; }

    public double DiscountValue { get; set; }

    public int? WeekdaysMask { get; set; }

    public short? AllowCombining { get; set; }

    public short ThresholdType { get; set; }
}
