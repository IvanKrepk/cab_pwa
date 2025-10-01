using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CurEventSize
{
    [Key]
    [Column("EvtGUID")]
    public Guid EvtGuid { get; set; }

    public int? Size { get; set; }
}
