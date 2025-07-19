using Domain.Entities;
using Application.DataBase;
using Application.Services.CopyUser;
using Application.DTO;

public class UserAccessService : IUserAccessService
{
    private static Dictionary<int, List<GeneralUserAccessLevel>> TempAccessStorage = new Dictionary<int, List<GeneralUserAccessLevel>>();

    private readonly IAcsdataContext _context;
    public UserAccessService(IAcsdataContext context)
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
                Message = $"کاربری انتخاب نشد :( لطفا برای انتخاب کاربر برروی آن ها دابل کلیک فرماییید",
            };
        }
        else if (sourceUser == targetUser)
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = $":) نمیتونی دسترسی افراد یکسان رو کپی کنی",
            };
        }

        // دریافت دسترسی‌های کاربر مبدا
        var sourceAccessLevels = _context.GeneralUserAccessLevel
            .Where(a => a.UserId == sourceUserId)
            .ToList();

        if (!sourceAccessLevels.Any())
        {
            return new ResultDto
            {
                IsSuccess = false,
                Message = $"کاربر مبدا دسترسی ندارد",
            };
        }

        var targetAccessLevels = _context.GeneralUserAccessLevel.Where(a => a.UserId == targetUserId).ToList();

        if (targetAccessLevels.Any())
        {
            TempAccessStorage[targetUserId] = targetAccessLevels.Select(a => new GeneralUserAccessLevel
            {
                UserId = a.UserId,
                AccessLevelId = a.AccessLevelId,
                AccessView = a.AccessView,
                AccessNew = a.AccessNew,
                AccessEdit = a.AccessEdit,
                AccessDelete = a.AccessDelete,
                AccessFirstConfirm = a.AccessFirstConfirm,
                AccessSecondConfirm = a.AccessSecondConfirm,
                AccessPrint = a.AccessPrint,
            }).ToList();
        }

        // حذف دسترسی‌های قبلی کاربر مقصد
  
            
            _context.GeneralUserAccessLevel.RemoveRange(targetAccessLevels);

        // کپی کردن دسترسی‌ها
        var newAccessLevels = sourceAccessLevels.Select(a => new GeneralUserAccessLevel
        {
            UserId = targetUserId,
            AccessLevelId= a.AccessLevelId,
            AccessView = a.AccessView, //view only
            AccessNew = copyOnlyView ? false : a.AccessView,
            AccessEdit = copyOnlyView ? false : a.AccessEdit,
            AccessDelete = copyOnlyView ? false : a.AccessDelete,
            AccessFirstConfirm = copyOnlyView ? false : a.AccessFirstConfirm,
            AccessSecondConfirm = copyOnlyView ? false : a.AccessSecondConfirm,
            AccessPrint = a.AccessPrint, //view only
        }).ToList();
        _context.GeneralUserAccessLevel.AddRange(newAccessLevels);
        _context.SaveChanges();


        return new ResultDto
        {
            IsSuccess = true,
            Message = $"انتقال یافت  {targetUser.UserName}  به   {sourceUser.UserName} دسترسی",
        };
    }

    public ResultDto RestorePreviousAccess(int targetUserId)
    {
        if (!TempAccessStorage.ContainsKey(targetUserId))
            return new ResultDto { IsSuccess = false, Message = "هیچ دسترسی قبلی برای این کاربر ذخیره نشده است!" };

        // حذف دسترسی‌های فعلی کاربر مقصد
        var targetAccessLevels = _context.GeneralUserAccessLevel.Where(a => a.UserId == targetUserId);
        _context.GeneralUserAccessLevel.RemoveRange(targetAccessLevels);
        _context.SaveChanges();

        // بازیابی دسترسی‌های قبلی از حافظه موقت
        var previousAccessLevels = TempAccessStorage[targetUserId];
        _context.GeneralUserAccessLevel.AddRange(previousAccessLevels);
        _context.SaveChanges();

        // حذف اطلاعات موقت بعد از بازیابی
        TempAccessStorage.Remove(targetUserId);

        return new ResultDto
        {
            IsSuccess = true,
            Message = "دسترسی‌های قبلی با موفقیت بازگردانی شد"
        };
    }



}
