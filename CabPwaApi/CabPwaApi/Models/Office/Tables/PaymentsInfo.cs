using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class PaymentsInfo
{
    [Key]
    [Column("RTime")]
    public long Rtime { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? DocNumber { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("ContractID")]
    public int? ContractId { get; set; }
}
