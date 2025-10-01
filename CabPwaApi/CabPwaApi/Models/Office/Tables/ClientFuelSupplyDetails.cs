using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ClientFuelSupplyId", "ProductCode")]
public partial class ClientFuelSupplyDetails
{
    [Key]
    [Column("ClientFuelSupplyID")]
    public int ClientFuelSupplyId { get; set; }

    [Key]
    public int ProductCode { get; set; }

    public int Qty { get; set; }
}
