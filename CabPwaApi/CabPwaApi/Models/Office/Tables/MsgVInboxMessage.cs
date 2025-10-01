using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class MsgVInboxMessage
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string MessageText { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AfsName { get; set; } = null!;

    public short IsRead { get; set; }
}
