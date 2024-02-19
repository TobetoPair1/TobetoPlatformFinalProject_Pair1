using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helpers.FileHelper;

public interface IFileHelper
{
    //root-> dizin
    //filePath-> dosyaismi.jpg

    string Upload(IFormFile file, string root);
    void Delete(string filePath);
    string Update(IFormFile file, string filePath, string root);

}