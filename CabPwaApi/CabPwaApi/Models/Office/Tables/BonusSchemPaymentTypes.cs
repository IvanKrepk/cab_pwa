using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class BonusSchemPaymentTypes
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int SchemaId { get; set; }

    public int PaymentType { get; set; }
}
