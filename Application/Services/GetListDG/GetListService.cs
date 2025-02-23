using Application.DataBase;

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
            var MabdaQuery = databaseContext.ComproUsers.AsQueryable();

            if (!string.IsNullOrEmpty(searchKey))
            {
                MabdaQuery = MabdaQuery.Where(p => p.UserName.Contains(searchKey));
            }

            var contacts = MabdaQuery.Select(p => new GetListDGDto { UserName = p.UserName, Code = p.Code, Id = p.Id }).ToList();

            return contacts;

        }
    }
}
