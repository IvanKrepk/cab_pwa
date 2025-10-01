using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VCardHistory
{
    public int AccountNumber { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CardGraphNumber { get; set; }

    public int CardNumber { get; set; }

    [Column("CardTypeNAme")]
    [StringLength(2)]
    [Unicode(false)]
    public string? CardTypeName { get; set; }

    public int? PinCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OperDateTime { get; set; }

    [StringLength(130)]
    [Unicode(false)]
    public string? OperationName { get; set; }

    public short Operation { get; set; }

    public short? CardType { get; set; }
}
