using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("PriceContractId", "ProductCode")]
public partial class ClientFuelPrices
{
    [Key]
    [Column("PriceContractID")]
    public int PriceContractId { get; set; }

    [Key]
    public int ProductCode { get; set; }

    public double UnitPrice { get; set; }

    public double? Qty { get; set; }
}
