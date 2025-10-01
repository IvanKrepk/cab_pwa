using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VPurseNames
{
    public int Code { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Name { get; set; } = null!;
}
