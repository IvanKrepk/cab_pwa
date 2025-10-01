using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class LoadingPoints
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int ClientCode { get; set; }

    [Column("GID")]
    [StringLength(36)]
    [Unicode(false)]
    public string Gid { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string NameAndAddress { get; set; } = null!;

    public byte IsRrStation { get; set; }
}
