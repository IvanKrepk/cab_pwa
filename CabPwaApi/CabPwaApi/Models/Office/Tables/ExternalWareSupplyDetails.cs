using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class ExternalWareSupplyDetails
{
    [Key]
    public int SupplyCode { get; set; }

    public double? DocSumm { get; set; }

    [Column("NDSSumm")]
    public double? Ndssumm { get; set; }

    [Column("NPSumm")]
    public double? Npsumm { get; set; }

    public double? RetExtra { get; set; }

    [Column("RetNDS")]
    public double? RetNds { get; set; }

    [Column("RetNP")]
    public double? RetNp { get; set; }

    [Column("NDS")]
    public double? Nds { get; set; }

    [Column("NP")]
    public double? Np { get; set; }

    [Column("IncludeNDS")]
    public short? IncludeNds { get; set; }

    [Column("IncludeNP")]
    public short? IncludeNp { get; set; }

    [Column("primaryDocNo")]
    [StringLength(250)]
    [Unicode(false)]
    public string? PrimaryDocNo { get; set; }

    [Column("primaryDocDT", TypeName = "datetime")]
    public DateTime? PrimaryDocDt { get; set; }

    [Column("primaryInvoiceDocNo")]
    [StringLength(250)]
    [Unicode(false)]
    public string? PrimaryInvoiceDocNo { get; set; }

    [Column("primaryInvoiceDocDT", TypeName = "datetime")]
    public DateTime? PrimaryInvoiceDocDt { get; set; }

    [Column("NDSRoundByItem")]
    public byte NdsroundByItem { get; set; }
}
