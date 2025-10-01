using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class AccountTypeNames
{
    [Key]
    public short Code { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string Name { get; set; } = null!;
}
