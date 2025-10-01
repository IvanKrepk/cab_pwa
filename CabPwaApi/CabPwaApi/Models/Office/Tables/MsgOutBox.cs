using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("Msg_OutBox")]
public partial class MsgOutBox
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public short IsAllReceipt { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("MsgOutBox")]
    public virtual MsgMessages IdNavigation { get; set; } = null!;
}
