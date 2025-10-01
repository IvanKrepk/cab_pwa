using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("TradeObjId", "GroupId")]
public partial class TradeObjGrouping
{
    [Key]
    [Column("TradeObjID")]
    public int TradeObjId { get; set; }

    [Key]
    [Column("GroupID")]
    public int GroupId { get; set; }
}
