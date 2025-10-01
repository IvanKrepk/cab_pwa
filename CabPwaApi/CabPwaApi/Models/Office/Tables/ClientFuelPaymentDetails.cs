using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("FuelPaymentId", "ProductCode")]
public partial class ClientFuelPaymentDetails
{
    [Key]
    [Column("FuelPaymentID")]
    public int FuelPaymentId { get; set; }

    [Key]
    public int ProductCode { get; set; }

    public int Qty { get; set; }
}
