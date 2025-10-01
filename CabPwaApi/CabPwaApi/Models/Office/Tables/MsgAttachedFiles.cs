using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("Msg_AttachedFiles")]
public partial class MsgAttachedFiles
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("Msg_Messages_ID")]
    public int MsgMessagesId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string FileName { get; set; } = null!;

    [ForeignKey("MsgMessagesId")]
    [InverseProperty("MsgAttachedFiles")]
    public virtual MsgMessages MsgMessages { get; set; } = null!;

    [InverseProperty("MsgAttachedFiles")]
    public virtual ICollection<MsgSplitFile32k> MsgSplitFile32k { get; set; } = new List<MsgSplitFile32k>();
}
