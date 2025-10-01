using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VPaymentTypeGroups
{
    [Column("id")]
    public int Id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public byte Reserved { get; set; }
}
