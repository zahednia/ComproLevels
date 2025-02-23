using Application.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCompro.Services.GetListDG
{
    public class GetListService : IGetListService
    {
        private readonly IDatabaseContext databaseContext;

        public GetListService(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public List<GetListDGDto> Execute(string? searchKey = null)
        {
            var ContactQuery = databaseContext.ComproUsers.AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                ContactQuery = ContactQuery.Where(p => p.UserName.Contains(searchKey));
            }

            var contacts = ContactQuery.Select(p => new GetListDGDto{UserName = p.UserName,Code = p.Code,}).ToList();

            return contacts;

        }
    }
}
