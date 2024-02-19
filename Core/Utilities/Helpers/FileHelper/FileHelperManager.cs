using Core.Utilities.Helpers.GuidHelpers;
using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper;

public class FileHelperManager : IFileHelper
{
    public string Upload(IFormFile file, string root)
    {
        if (file.Length > 0)
        {
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string extension = Path.GetExtension(file.FileName);
            string guid = GuidHelper.CreateGuid();
            string filePath = guid + extension;

            using (FileStream fileStream = File.Create(root + filePath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
                return filePath;
            }
        }
        return null;
    }
    public void Delete(string filePath)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
    }

    public string Update(IFormFile file, string filePath, string root)
    {
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        return Upload(file, root);
    }


}