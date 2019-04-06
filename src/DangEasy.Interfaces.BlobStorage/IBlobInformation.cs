using System;

namespace DangEasy.Interfaces.BlobStorage
{
    public interface IBlobInformation
    {
        string AbsoluteUri { get; set; }
        string Path { get; set; }
        DateTime Created { get; set; }
        DateTime Modified { get; set; }
        long Size { get; set; }
    }
}