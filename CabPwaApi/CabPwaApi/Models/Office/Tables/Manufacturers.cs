using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Manufacturers
{
    [Key]
    [Column("ContractorID")]
    public int ContractorId { get; set; }

    [ForeignKey("ContractorId")]
    [InverseProperty("Manufacturers")]
    public virtual Contractors Contractor { get; set; } = null!;
}
