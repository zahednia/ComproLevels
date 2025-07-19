using Application.DataBase;
using Application.DTO;

namespace ApplicationCompro.Services.ShowName
{
    public class ShowNameService : IShowName
    {


        private readonly IAcsdataContext databaseContext;
        public ShowNameService(IAcsdataContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }


        public ResultDto<ShowNameDTO> ShowName(ShowNameDTO showNameDTO, int Code)
        {
            var contact = databaseContext.Personals.FirstOrDefault(p => p.Code == Code);
            if (contact == null)
            {
                return new ResultDto<ShowNameDTO>
                {
                    IsSuccess = false,
                    Message = "کد پرسنلی یافت نشد"
                };
            }
            var data = new ShowNameDTO
            {
                 Code = contact.Code,
                 FullNameE = contact.FullNameE
            };
            return new ResultDto<ShowNameDTO>
            {
                Data = data,
                IsSuccess = true,
            };
        }
    }
}
