using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("Msg_InBox")]
public partial class MsgInBox
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public short IsRead { get; set; }

    [ForeignKey("Id")]
    [InverseProperty("MsgInBox")]
    public virtual MsgMessages IdNavigation { get; set; } = null!;
}
