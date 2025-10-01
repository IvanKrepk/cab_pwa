using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Contracts
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int ClientCode { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    [Column("ContractorSellerID")]
    public int ContractorSellerId { get; set; }

    public int? CreditDepth { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Info { get; set; } = null!;
}
