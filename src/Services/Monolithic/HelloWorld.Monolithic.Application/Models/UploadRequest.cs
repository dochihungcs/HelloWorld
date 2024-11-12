namespace HelloWorld.Monolithic.Application.Models;

public sealed class UploadRequest
{
    public string FileName { get; set; }

    public string FileExtension { get; set; }

    public string Prefix { get; set; }

    public Stream Stream { get; set; }

    public long Size { get; set; }
}
