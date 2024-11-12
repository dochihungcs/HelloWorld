namespace HelloWorld.Monolithic.Application.Models;

public sealed class DownloadResult
{
    public string PresignedUrl { get; set; }

    public int ExpiryTime { get; set; }

    public string FileName { get; set; }

    public MemoryStream MemoryStream { get; set; }
}
