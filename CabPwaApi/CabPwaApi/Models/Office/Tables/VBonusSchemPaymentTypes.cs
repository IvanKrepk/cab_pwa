using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VBonusSchemPaymentTypes
{
    [Column("SchemaID")]
    public int SchemaId { get; set; }

    [StringLength(90)]
    [Unicode(false)]
    public string? PaymentName { get; set; }

    public int OldPaymentType { get; set; }

    public double? PaymentType { get; set; }
}
