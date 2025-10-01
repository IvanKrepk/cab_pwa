using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CurAccountTrans
{
    [Key]
    public long TransTime { get; set; }

    public int AccountNumber { get; set; }

    public short ClientCode { get; set; }

    [Column("AfsID")]
    public int AfsId { get; set; }

    public short PumpNo { get; set; }

    public short ProductCode { get; set; }

    public double ProductPrice { get; set; }

    public double Quantity { get; set; }

    public double Cost { get; set; }

    public short DiscountType { get; set; }

    public double Discount { get; set; }

    public int Info { get; set; }

    public int? PurseCode { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? WayBillNumber { get; set; }

    public double? OrigCost { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransDateTime { get; set; }

    public byte TransTypeEx { get; set; }
}
