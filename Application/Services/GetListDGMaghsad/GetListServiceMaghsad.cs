using Application.DataBase;

namespace ApplicationCompro.Services.GetListDG
{
    public class GetListServiceMaghsad : IGetListServiceMaghsad
    {


        private readonly IDatabaseContext databaseContext;
        public GetListServiceMaghsad(IDatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }


        public List<GetListDGMaghsadDto> ExecuteMaghsad(string searchKey = null)
        {
            var ContactQuery = databaseContext.Users.AsQueryable();
            if (!string.IsNullOrEmpty(searchKey))
            {
                ContactQuery = ContactQuery.Where(p => p.UserName.Contains(searchKey));
            }
            var contacts = ContactQuery.Select(p => new GetListDGMaghsadDto { UserName = p.UserName,Code = p.Code, Id = p.Id }).ToList();
            return contacts;
        }
    }
}
