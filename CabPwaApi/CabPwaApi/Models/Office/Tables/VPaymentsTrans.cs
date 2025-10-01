using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VPaymentsTrans
{
    public long TransTime { get; set; }

    public int AccountNumber { get; set; }

    public short ClientCode { get; set; }

    public short TransType { get; set; }

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

    public double? DailyLimitOverdraft { get; set; }

    public double? MonthlyLimitOverdraft { get; set; }

    public int? PurseCode { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? WayBillNumber { get; set; }

    public double? OrigCost { get; set; }

    public short? TankNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TransDateTime { get; set; }

    public byte TransTypeEx { get; set; }

    [Column("RTime")]
    public long? Rtime { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("ContractID")]
    public int? ContractId { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? Paymenttype { get; set; }
}
