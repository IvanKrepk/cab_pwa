using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Table("single_ware_sells")]
[Index("RecKey", Name = "IX_SingleWSells1")]
[Index("ObjectId", Name = "IX_Single_Ware_sell_ObjID")]
public partial class SingleWareSells
{
    [Key]
    [Column("rec_id")]
    public int RecId { get; set; }

    [Column("rec_key")]
    public int RecKey { get; set; }

    [Column("object_id")]
    public int ObjectId { get; set; }

    [Column("ware_code")]
    public int WareCode { get; set; }

    [Column("was_at", TypeName = "datetime")]
    public DateTime WasAt { get; set; }

    [Column("ws_id")]
    public int WsId { get; set; }

    [Column("payment_id")]
    public int PaymentId { get; set; }

    [Column("quantity")]
    public double Quantity { get; set; }

    [Column("price")]
    public double Price { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? CardNumber { get; set; }

    [Column("orig_price")]
    public double? OrigPrice { get; set; }

    [Column("self_price")]
    public double? SelfPrice { get; set; }

    [Column("BonusChargeSchemaID")]
    public int? BonusChargeSchemaId { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? BonusCardNumber { get; set; }

    [Column("CheckID")]
    public int? CheckId { get; set; }

    public int? PaymentSubType { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Mark { get; set; }
}
