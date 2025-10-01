using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("CorrectionId", "ProductCode")]
public partial class ClientFuelRemainderCorrectionDetails
{
    [Key]
    [Column("CorrectionID")]
    public int CorrectionId { get; set; }

    [Key]
    public int ProductCode { get; set; }

    public int QtyDelta { get; set; }
}
