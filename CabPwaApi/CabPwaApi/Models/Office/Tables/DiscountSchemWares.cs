using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class DiscountSchemWares
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int SchemaId { get; set; }

    public int WareCode { get; set; }

    public short? RecordType { get; set; }
}
