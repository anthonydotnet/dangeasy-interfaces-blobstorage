using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DangEasy.Interfaces.BlobStorage
{
    public interface IBlobStorageClient
    {
        Task<bool> CreateContainerAsync(string containerName);
        Task<bool> DeleteAsync(string path);
        Task<bool> ExistsAsync(string path);
        Task<Stream> GetAsync(string path);
        Task<IBlobInformation> GetInfoAsync(string path);
        Task<IEnumerable<string>> GetListAsync(string path);
        Task<bool> SaveAsync(string filePath, Stream stream);
    }
}