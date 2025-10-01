using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("Msg_SplitFile32k")]
public partial class MsgSplitFile32k
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("Msg_AttachedFiles_ID")]
    public int MsgAttachedFilesId { get; set; }

    [Column(TypeName = "image")]
    public byte[] FilePart { get; set; } = null!;

    [ForeignKey("MsgAttachedFilesId")]
    [InverseProperty("MsgSplitFile32k")]
    public virtual MsgAttachedFiles MsgAttachedFiles { get; set; } = null!;
}
