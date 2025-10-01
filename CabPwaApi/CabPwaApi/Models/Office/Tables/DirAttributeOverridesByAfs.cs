using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("DirAttributeOverridesByAFS")]
public partial class DirAttributeOverridesByAfs
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int ItemCode { get; set; }

    public byte DirType { get; set; }

    [Column("AFSID")]
    public int Afsid { get; set; }

    public byte? TaxSystem { get; set; }

    public int? AgentAttribute { get; set; }

    public int? EcrItemType { get; set; }

    [Column("AgentOwnerContractorID")]
    public int? AgentOwnerContractorId { get; set; }

    [Column("ProductVAT")]
    public int? ProductVat { get; set; }
}
