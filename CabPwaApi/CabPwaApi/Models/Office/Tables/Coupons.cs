using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Coupons
{
    [Key]
    public short CouponCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CouponName { get; set; } = null!;

    public short Active { get; set; }

    public short InLiters { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Nominals { get; set; }

    public short? InputByMask { get; set; }

    public short? ImManualInput { get; set; }

    public short? NumberingBySeries { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? InputMask { get; set; }

    public short? IsCard { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? AdvText { get; set; }

    public short? DontPrintChecks { get; set; }

    public int? EcrSection { get; set; }

    public byte DontSearchInGivenCoupons { get; set; }

    public double BankCommission { get; set; }

    public byte UseCreditReceiptPaymentType { get; set; }
}
