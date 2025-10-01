using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CabPwaApi.Models.Office.Tables;

public partial class CardHistory
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    public int AccountNumber { get; set; }

    public int CardNumber { get; set; }

    public int? CardGraphNumber { get; set; }

    public int? CardEmitentCode { get; set; }

    public int? PinCode { get; set; }

    public short? CardType { get; set; }

    /// <summary>
    /// 
    /// 0 - инициализация истории (пишется дата открытия счета)
    /// 1 - выдача карты
    /// 2 - перевыдача карты
    /// 3 - возврат карты
    /// 4 - Ообновление пина и т.п.
    /// 5 - Добавление в стоп-лист
    /// 6 - Удаление из стоп-листа
    /// </summary>
    public short Operation { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime OperDateTime { get; set; }

    [ForeignKey("AccountNumber")]
    [InverseProperty("CardHistory")]
    public virtual Accounts AccountNumberNavigation { get; set; } = null!;
}
