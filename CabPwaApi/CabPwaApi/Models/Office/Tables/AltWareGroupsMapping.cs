using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class AltWareGroupsMapping
{
    public int AltGroupCode { get; set; }

    public int? BaseGroupCode { get; set; }

    public int? WareCode { get; set; }
}
