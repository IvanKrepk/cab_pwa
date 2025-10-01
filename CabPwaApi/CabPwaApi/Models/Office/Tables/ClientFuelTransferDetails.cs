using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("TransferId", "ProductCode")]
public partial class ClientFuelTransferDetails
{
    [Key]
    [Column("TransferID")]
    public int TransferId { get; set; }

    [Key]
    public int ProductCode { get; set; }

    public int Qty { get; set; }
}
