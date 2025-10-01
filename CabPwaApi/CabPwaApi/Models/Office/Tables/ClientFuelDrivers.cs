using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[PrimaryKey("ClientCode", "FuelDriverCode")]
public partial class ClientFuelDrivers
{
    [Key]
    public int ClientCode { get; set; }

    [Key]
    public int FuelDriverCode { get; set; }
}
