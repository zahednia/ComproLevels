namespace ApplicationCompro.Services.GetListDG
{
    public interface IGetListService
    {
        List<GetListDGDto> Execute(string searchKey = null);
    }
}
