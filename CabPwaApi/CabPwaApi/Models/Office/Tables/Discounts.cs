using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ClientCode", "RecNo")]
[Index("ClientCode", "ProductCode", "StartDate", "EndDate", Name = "UQ_Discounts", IsUnique = true, IsDescending = new[] { false, false, true, false })]
public partial class Discounts
{
    [Key]
    public int RecNo { get; set; }

    [Key]
    public int ClientCode { get; set; }

    public short ProductCode { get; set; }

    public short DiscountType { get; set; }

    public double Discount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("ContractID")]
    public int? ContractId { get; set; }
}
