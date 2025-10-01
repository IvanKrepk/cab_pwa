using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class MsgVAdressat
{
    [Column("ID")]
    public int Id { get; set; }

    public short AfsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceiptDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AfsName { get; set; } = null!;

    public int IsReceived { get; set; }
}
