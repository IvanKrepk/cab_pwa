using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ClientCode", "AfsId")]
public partial class ClientTradePlaces
{
    [Key]
    public int ClientCode { get; set; }

    [Key]
    [Column("AfsID")]
    public int AfsId { get; set; }
}
