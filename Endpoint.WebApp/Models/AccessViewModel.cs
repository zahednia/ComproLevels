using ApplicationCompro.Services.GetListDG;

namespace Endpoint.WebApp.Models
{
    public class AccessViewModel
    {
        public List<GetListDGDto>? MabdaList { get; set; }
        public List<GetListDGDto>? MaghsadList { get; set; }
    }
}
