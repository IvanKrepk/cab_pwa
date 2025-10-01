using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class CurRest
{
    public int AccountNumber { get; set; }

    public int PurseContentCode { get; set; }

    public double RestInfo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RestUpdateTime { get; set; }
}
