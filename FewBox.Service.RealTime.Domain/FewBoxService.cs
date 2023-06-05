/*using FewBox.Service.RealTime.Model.Configs;
using FewBox.Service.RealTime.Model.Dtos;
using FewBox.Service.RealTime.Model.Services;

namespace FewBox.Service.RealTime.Domain
{
    public class FewBoxService : IFewBoxService
    {
        private FewBoxConfig FewBoxConfig { get; set; }
        public FewBoxService(FewBoxConfig fewBoxConfig)
        {
            this.FewBoxConfig = fewBoxConfig;
        }

        public AuthorDto GetAuthor()
        {
            return new AuthorDto{
                Name = this.FewBoxConfig.Author
            };
        }
    }
}*/