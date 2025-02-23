using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCompro.Services.GetListDG
{
    public interface IGetListService
    {
        List<GetListDGDto> Execute(string? searchKey = null);
    }
}
