using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
[Index("TransTime", Name = "IX_AccTransWaresTT")]
public partial class AccountTransWares
{
    [Column("transTime")]
    public long TransTime { get; set; }

    [Column("wareCode")]
    public int WareCode { get; set; }

    [Column("price")]
    public double Price { get; set; }

    [Column("amount")]
    public double Amount { get; set; }
}
