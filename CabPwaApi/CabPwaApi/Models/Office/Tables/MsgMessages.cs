using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("Msg_Messages")]
public partial class MsgMessages
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(8000)]
    [Unicode(false)]
    public string MessageText { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual ICollection<MsgAdressat> MsgAdressat { get; set; } = new List<MsgAdressat>();

    [InverseProperty("MsgMessages")]
    public virtual ICollection<MsgAttachedFiles> MsgAttachedFiles { get; set; } = new List<MsgAttachedFiles>();

    [InverseProperty("IdNavigation")]
    public virtual MsgInBox? MsgInBox { get; set; }

    [InverseProperty("IdNavigation")]
    public virtual MsgOutBox? MsgOutBox { get; set; }
}
