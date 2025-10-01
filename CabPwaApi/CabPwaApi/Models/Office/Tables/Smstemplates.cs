using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("SMSTemplates")]
public partial class Smstemplates
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    [Column("SMSTemplateText")]
    [StringLength(500)]
    [Unicode(false)]
    public string SmstemplateText { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string VariableDescript { get; set; } = null!;
}
