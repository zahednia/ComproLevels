using Application.DTO;

namespace Application.Services.CopyUser
{
    public interface IUserAccessService
    {
        ResultDto CopyUserAccess(int sourceUserId, int targetUserId, bool copyOnlyView = false);
        ResultDto RestorePreviousAccess(int targetUserId);
    }

}
