using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCompro.Services.GetListDG
{
    public interface IGetListServiceMaghsad
    {
        List<GetListDGMaghsadDto> ExecuteMaghsad(string? searchKey = null);
    }
}
