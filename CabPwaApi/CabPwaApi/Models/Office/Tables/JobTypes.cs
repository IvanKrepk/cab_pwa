using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class JobTypes
{
    [Key]
    [Column("JobID")]
    public int JobId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string JobTitle { get; set; } = null!;
}
