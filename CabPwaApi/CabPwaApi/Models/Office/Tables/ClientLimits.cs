using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class ClientLimits
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int ClientCode { get; set; }

    public int ProductCode { get; set; }

    public short LimitType { get; set; }

    public int LimitValue { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime StartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    public int SignalRemainder { get; set; }

    public double Remainder { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RemainderUpdateTime { get; set; }

    [Column("ContractID")]
    public int? ContractId { get; set; }
}
