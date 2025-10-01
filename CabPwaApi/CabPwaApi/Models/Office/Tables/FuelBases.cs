using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class FuelBases
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public byte Active { get; set; }

    [InverseProperty("FuelBase")]
    public virtual ICollection<FuelBasesDeliveryPrices> FuelBasesDeliveryPrices { get; set; } = new List<FuelBasesDeliveryPrices>();
}
