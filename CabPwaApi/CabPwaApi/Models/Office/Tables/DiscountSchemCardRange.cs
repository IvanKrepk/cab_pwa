using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class DiscountSchemCardRange
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int SchemaId { get; set; }

    public int? FirstCardNumber { get; set; }

    public int? LastCardNumber { get; set; }
}
