using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("Id", "AfsId")]
[Table("Msg_Adressat")]
public partial class MsgAdressat
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Key]
    public short AfsId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceiptDate { get; set; }

    [ForeignKey("AfsId")]
    [InverseProperty("MsgAdressat")]
    public virtual Afs Afs { get; set; } = null!;

    [ForeignKey("Id")]
    [InverseProperty("MsgAdressat")]
    public virtual MsgMessages IdNavigation { get; set; } = null!;
}
