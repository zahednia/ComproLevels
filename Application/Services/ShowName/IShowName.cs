using Application.DTO;

namespace ApplicationCompro.Services.ShowName
{
    public interface IShowName
    {
        ResultDto<ShowNameDTO> ShowName(ShowNameDTO showNameDTO, int Code);
    }
}
