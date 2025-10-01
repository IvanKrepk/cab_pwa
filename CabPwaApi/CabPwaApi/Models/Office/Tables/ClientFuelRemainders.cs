using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ClientCode", "ProductCode", "RemainderType")]
public partial class ClientFuelRemainders
{
    [Key]
    public int ClientCode { get; set; }

    [Key]
    public int ProductCode { get; set; }

    [Key]
    public int RemainderType { get; set; }

    public int Remainder { get; set; }

    public int Allocated { get; set; }
}
