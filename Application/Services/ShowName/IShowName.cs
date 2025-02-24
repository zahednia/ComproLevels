using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCompro.Services.ShowName
{
    public interface IShowName
    {
        ResultDto<ShowNameDTO> ShowName(ShowNameDTO showNameDTO , int Code);
    }
}
