using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class PaymentTypeGroupsDetail
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("PaymentTypeGroupID")]
    public int PaymentTypeGroupId { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string PaymentTypeName { get; set; } = null!;

    public int MinValue { get; set; }

    public int MaxValue { get; set; }

    public byte IsMainInterval { get; set; }

    public byte IsActive { get; set; }

    public byte Reserved { get; set; }

    [ForeignKey("PaymentTypeGroupId")]
    [InverseProperty("PaymentTypeGroupsDetail")]
    public virtual PaymentTypeGroups PaymentTypeGroup { get; set; } = null!;
}
