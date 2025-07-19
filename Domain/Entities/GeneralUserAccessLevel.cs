using System;
using System.Collections.Generic;
namespace Domain.Entities;

public partial class GeneralUserAccessLevel
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public int? AccessLevelId { get; set; }

    /// <summary>
    /// مشاهده فرم
    /// </summary>
    public bool? AccessView { get; set; }

    /// <summary>
    /// ایجاد رکورد جدید
    /// </summary>
    public bool? AccessNew { get; set; }

    /// <summary>
    /// ویرایش رکورد جاری
    /// </summary>
    public bool? AccessEdit { get; set; }

    /// <summary>
    /// حذف رکورد جاری
    /// </summary>
    public bool? AccessDelete { get; set; }

    /// <summary>
    /// سطح دسترسی خاص شماره 1
    /// </summary>
    public bool? AccessFirstConfirm { get; set; }

    /// <summary>
    /// سطح دسترسی خاص شماره 2
    /// </summary>
    public bool? AccessSecondConfirm { get; set; }

    /// <summary>
    /// چاپ
    /// </summary>
    public bool? AccessPrint { get; set; }
}
