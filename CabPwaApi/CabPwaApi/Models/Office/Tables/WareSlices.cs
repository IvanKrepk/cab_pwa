using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("ware_slices")]
public partial class WareSlices
{
    [Key]
    [Column("code")]
    public int Code { get; set; }

    [Column("slice_time", TypeName = "datetime")]
    public DateTime SliceTime { get; set; }

    [Column("object_id")]
    public int ObjectId { get; set; }
}
