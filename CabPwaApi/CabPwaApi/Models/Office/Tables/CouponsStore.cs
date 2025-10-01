using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CouponsStore
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int CouponCode { get; set; }

    [Column("SeriesID")]
    public int SeriesId { get; set; }

    public int FirstNumber { get; set; }

    public int LastNumber { get; set; }

    public DateOnly StoreDate { get; set; }
}
