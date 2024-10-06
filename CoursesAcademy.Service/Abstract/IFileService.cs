using Microsoft.AspNetCore.Http;

namespace CoursesAcademy.Service.Abstracts
{
    public interface IFileService
    {
        public Task<string> UploadImage(string Location, IFormFile file);
    }
}
