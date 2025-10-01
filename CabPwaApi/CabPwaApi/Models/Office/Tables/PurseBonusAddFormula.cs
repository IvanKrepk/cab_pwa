using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class PurseBonusAddFormula
{
    [Key]
    public int Id { get; set; }

    public int SchemaId { get; set; }

    public int PurseCode { get; set; }

    [StringLength(254)]
    [Unicode(false)]
    public string? Formula { get; set; }
}
