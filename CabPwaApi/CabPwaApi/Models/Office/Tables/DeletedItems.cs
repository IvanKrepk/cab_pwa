using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

[Keyless]
[Index("Version", Name = "IX_DeletedItemsByVersion")]
public partial class DeletedItems
{
    public int Version { get; set; }

    public int ItemType { get; set; }

    public int ItemCode { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeletionTime { get; set; }

    public int? DeletedBy { get; set; }
}
