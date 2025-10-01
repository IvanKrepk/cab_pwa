using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
public partial class VWareRemainderAfterLastRelay
{
    public int WareCode { get; set; }

    [Column("AFSID")]
    public int Afsid { get; set; }

    public double Remainder { get; set; }
}
