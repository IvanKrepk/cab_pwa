using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ClientCode", "Id")]
[Index("ClientCode", "StartDate", Name = "IxClientPriceContracts", IsDescending = new[] { false, true })]
public partial class ClientFuelPriceContracts
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("GID")]
    [StringLength(36)]
    [Unicode(false)]
    public string Gid { get; set; } = null!;

    [Key]
    public int ClientCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ContractNumber { get; set; } = null!;

    public DateOnly ContractDate { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public int PriceType { get; set; }
}
