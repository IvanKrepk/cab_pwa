using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VClientsTags
{
    [StringLength(100)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public short ClientCode { get; set; }
}
