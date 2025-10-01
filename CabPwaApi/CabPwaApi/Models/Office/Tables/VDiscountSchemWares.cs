using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VDiscountSchemWares
{
    public int SchemaId { get; set; }

    public int WareCode { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string? WareName { get; set; }
}
