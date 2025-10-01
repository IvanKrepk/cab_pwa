using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWebLoginsAndAccounts
{
    public short ClientCode { get; set; }

    [Column("ID")]
    public int Id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string WebLogin { get; set; } = null!;

    public short AllAccounts { get; set; }

    public int AccountNumber { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? CarName { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? CarNumber { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? AccountName { get; set; }
}
