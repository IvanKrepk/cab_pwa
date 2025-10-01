using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class Keys
{
    [Key]
    [Column("KeyID")]
    public int KeyId { get; set; }

    [Column(TypeName = "image")]
    public byte[] PublicKey { get; set; } = null!;

    [Column(TypeName = "image")]
    public byte[] PrivateKey { get; set; } = null!;
}
