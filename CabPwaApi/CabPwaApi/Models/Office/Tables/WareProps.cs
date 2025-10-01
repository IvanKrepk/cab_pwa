using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("WareCode", "PropCode")]
public partial class WareProps
{
    [Key]
    public int WareCode { get; set; }

    [Key]
    public int PropCode { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string PropValue { get; set; } = null!;
}
