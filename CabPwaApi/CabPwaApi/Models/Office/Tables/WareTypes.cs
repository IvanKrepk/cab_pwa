using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class WareTypes
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Name { get; set; }
}
