using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VPurseProducts
{
    public int ProductCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ProductName { get; set; } = null!;
}
