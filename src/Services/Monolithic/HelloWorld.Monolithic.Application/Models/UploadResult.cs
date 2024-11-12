namespace HelloWorld.Monolithic.Application.Models;

public sealed class UploadResult
{
    public bool Success { get; set; } = true;

    public string OriginalFileName { get; set; }

    public string CurrentFileName { get; set; }

    public long Size { get; set; }

    public string FileExtension { get; set; }

    public string Prefix { get; set; }

    public string ErrorMessage { get; set; }
}
