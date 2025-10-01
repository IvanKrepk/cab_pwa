using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
[Index("ClientCode", "ProductCode", "ThresholdNumber", Name = "IX_ClientCode_ProductCode_ThresholdNumber", IsUnique = true)]
public partial class ClientsThresholdDiscount
{
    [Column("ID")]
    public int Id { get; set; }

    public int ClientCode { get; set; }

    public int ProductCode { get; set; }

    public byte ThresholdNumber { get; set; }

    public int ThresholdValue { get; set; }

    public double DiscountValue { get; set; }
}
