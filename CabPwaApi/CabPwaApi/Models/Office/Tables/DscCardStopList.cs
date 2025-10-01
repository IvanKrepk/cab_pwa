using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Index("CardType", "FirstNumber", Name = "IX_DscCardStopListByFirstNumber")]
public partial class DscCardStopList
{
    [Key]
    [Column("RecID")]
    public int RecId { get; set; }

    public int CardType { get; set; }

    public int FirstNumber { get; set; }

    public int LastNumber { get; set; }
}
