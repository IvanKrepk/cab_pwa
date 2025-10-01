using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("AfsId", "NumPochunk")]
public partial class RequiredTradeObjFlags
{
    [Key]
    public short AfsId { get; set; }

    [Key]
    [Column("NumPOChunk")]
    public short NumPochunk { get; set; }

    public int CheckedOptions { get; set; }

    public int UnCheckedOptions { get; set; }

    [ForeignKey("AfsId")]
    [InverseProperty("RequiredTradeObjFlags")]
    public virtual Afs Afs { get; set; } = null!;
}
