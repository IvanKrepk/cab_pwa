using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class AlcoWareType
{
    [Key]
    public int Code { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Name { get; set; }

    public int Version { get; set; }
}
