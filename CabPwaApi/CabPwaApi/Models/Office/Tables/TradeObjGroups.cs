using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class TradeObjGroups
{
    [Key]
    [Column("GroupID")]
    public int GroupId { get; set; }

    [StringLength(240)]
    [Unicode(false)]
    public string? GroupName { get; set; }

    [StringLength(2048)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("ParentGroupID")]
    public int ParentGroupId { get; set; }
}
