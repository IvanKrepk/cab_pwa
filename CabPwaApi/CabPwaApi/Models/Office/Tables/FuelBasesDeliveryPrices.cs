using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class FuelBasesDeliveryPrices
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("FuelBaseID")]
    public int FuelBaseId { get; set; }

    [Column("AFSID")]
    public int Afsid { get; set; }

    public DateOnly PeriodBegin { get; set; }

    public DateOnly? PeriodEnd { get; set; }

    public double? Price { get; set; }

    [ForeignKey("FuelBaseId")]
    [InverseProperty("FuelBasesDeliveryPrices")]
    public virtual FuelBases FuelBase { get; set; } = null!;
}
