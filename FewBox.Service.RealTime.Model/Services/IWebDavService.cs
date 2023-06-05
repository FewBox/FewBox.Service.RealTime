using System.Threading.Tasks;

namespace FewBox.Service.RealTime.Model.Services
{
    public interface IWebDavService
    {
        Task<bool> UploadFile(string fileName, byte[] bytes);
        string GetFileUrl(string fileName);
    }
}