using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
[Table("ware_slice_items")]
[Index("OrigObjectId", Name = "IX_Ware_Slice_Items_ObjID")]
[Index("SliceCode", Name = "IX_ware_slice_items_code")]
public partial class WareSliceItems
{
    [Column("slice_code")]
    public int SliceCode { get; set; }

    [Column("ware_code")]
    public int WareCode { get; set; }

    [Column("quantity")]
    public double Quantity { get; set; }

    [Column("self_sum")]
    public double SelfSum { get; set; }

    [Column("orig_object_id")]
    public int? OrigObjectId { get; set; }
}
