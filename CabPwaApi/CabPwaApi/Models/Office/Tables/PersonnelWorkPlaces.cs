using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("PersonnelId", "AfsId")]
public partial class PersonnelWorkPlaces
{
    [Key]
    [Column("PersonnelID")]
    public int PersonnelId { get; set; }

    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }
}
