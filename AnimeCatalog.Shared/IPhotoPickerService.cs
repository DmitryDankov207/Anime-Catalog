using System.IO;
using System.Threading.Tasks;

namespace AnimeCatalog.Shared
{
    public interface IPhotoPickerService
    {
        Task<Stream> GetImageStreamAsync();
    }
}
