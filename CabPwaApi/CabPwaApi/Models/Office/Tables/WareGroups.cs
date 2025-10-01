using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class WareGroups
{
    [Key]
    public int Code { get; set; }

    [StringLength(32)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public int? Version { get; set; }

    public int? ParentGroupCode { get; set; }

    public byte? AllowSmartCardPayment { get; set; }

    public byte TaxSystem { get; set; }

    public byte? IsMarkable { get; set; }

    public int? MarkTypeCode { get; set; }

    public int? AgentAttribute { get; set; }

    [Column("AnotherECR")]
    public byte AnotherEcr { get; set; }

    public byte? NotAutoChangePrice { get; set; }

    [Column("AgentOwnerContractorID")]
    public int? AgentOwnerContractorId { get; set; }

    public DateOnly? WithOutEnteringMarkDate { get; set; }
}
