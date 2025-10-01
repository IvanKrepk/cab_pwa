using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
[Table("prop_defs")]
public partial class PropDefs
{
    [Column("client_props", TypeName = "text")]
    public string? ClientProps { get; set; }
}
