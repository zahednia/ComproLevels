using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.CopyUser
{
    public interface IUserAccessService
    {
        ResultDto CopyUserAccess(int sourceUserId, int targetUserId , bool copyOnlyView = false);
    }

}
