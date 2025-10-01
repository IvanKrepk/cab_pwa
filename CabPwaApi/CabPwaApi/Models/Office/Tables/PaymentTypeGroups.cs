using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class PaymentTypeGroups
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string Name { get; set; } = null!;

    public byte Reserved { get; set; }

    [InverseProperty("PaymentTypeGroup")]
    public virtual ICollection<PaymentTypeGroupsDetail> PaymentTypeGroupsDetail { get; set; } = new List<PaymentTypeGroupsDetail>();
}
