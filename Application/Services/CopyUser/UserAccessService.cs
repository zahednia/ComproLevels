using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.DataBase;
using Application.Services.CopyUser;
using Application.DTO;

public class UserAccessService : IUserAccessService
{
    private readonly IDatabaseContext _context;

    public UserAccessService(IDatabaseContext context)
    {
        _context = context;
    }

    public ResultDto CopyUserAccess(int sourceUserId, int targetUserId , bool copyOnlyView = false)
    {
        // بررسی وجود کاربران
        var sourceUser = _context.Users.Find(sourceUserId);
        var targetUser = _context.Users.Find(targetUserId);
        if (sourceUser == null || targetUser == null)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = $"کاربری انتخاب نشد . لطفا برای انتخاب کاربر برروی آن ها دابل کلیک فرماییید",
            };
        }

        // دریافت دسترسی‌های کاربر مبدا
        var sourceAccessLevels = _context.GeneralUserAccessLevel
            .Where(a => a.User_Id == sourceUserId)
            .ToList();

        if (!sourceAccessLevels.Any())
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = $"کاربر مبدا دسترسی ندارد",
            };
        }

        // حذف دسترسی‌های قبلی کاربر مقصد
        var targetAccessLevels = _context.GeneralUserAccessLevel.Where(a => a.User_Id == targetUserId);
        _context.GeneralUserAccessLevel.RemoveRange(targetAccessLevels);
       
        // کپی کردن دسترسی‌ها
        var newAccessLevels = sourceAccessLevels.Select(a => new GeneralUserAccessLevel
        {
            User_Id = targetUserId,
            AccessLevel_Id= a.AccessLevel_Id,
            AccessView = a.AccessView,
            AccessNew = copyOnlyView ? false : a.AccessView,
            AccessEdit = copyOnlyView ? false : a.AccessEdit,
            AccessDelete = copyOnlyView ? false : a.AccessDelete,
            AccessFirstConfirm = copyOnlyView ? false : a.AccessFirstConfirm,
            AccessSecondConfirm = copyOnlyView ? false : a.AccessSecondConfirm,
            AccessPrint = a.AccessPrint,

        }).ToList();

        _context.GeneralUserAccessLevel.AddRange(newAccessLevels);
        _context.SaveChanges();

        return new ResultDto
        {
            IsSuccess = true,
            Message = $"انتقال یافت  {targetUser.UserName}  به   {sourceUser.UserName} دسترسی",
        };
    }


}
