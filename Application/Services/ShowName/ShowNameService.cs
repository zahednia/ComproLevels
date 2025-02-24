using Application.DataBase;
using Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCompro.Services.ShowName
{
    public class ShowNameService : IShowName
    {
        private readonly IDatabaseContext databaseContext;

        public ShowNameService(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public ResultDto<ShowNameDTO> ShowName(ShowNameDTO showNameDTO, int Code)
        {
            throw new NotImplementedException();
        }
    }
}
