using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWareGroups
{
    public int Code { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public int? ParentGroupCode { get; set; }

    public byte? AllowSmartCardPayment { get; set; }

    public int? Version { get; set; }
}
