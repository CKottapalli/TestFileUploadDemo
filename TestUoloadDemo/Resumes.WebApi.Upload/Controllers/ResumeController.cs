using Microsoft.AspNetCore.Mvc;

namespace Resumes.WebApi.Upload.Controllers
{
    public class ResumeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult ResumeUpload()
        //{
        //    string BasePath = @"C:\Chandra\Resumes";

        //    if (!Directory.Exists(BasePath))
        //    {
        //        Directory.CreateDirectory(BasePath);
        //    }

        //    string relativePath = @"Resumes\" + DateTime.Now.ToString("yyyMMdd");

        //    string filesToUpload = Path.Combine(BasePath, relativePath);

        //    if (!Directory.Exists(filesToUpload))
        //    {
        //        Directory.CreateDirectory(filesToUpload);
        //    }

        //    FileInfo[] files = new DirectoryInfo(filesToUpload).GetFiles();

        //    if (files != null)
        //        Console.WriteLine($"Total Files: {files.Length}");

        //    return View();
        //}

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ResumeUpload()
        {
            string BasePath = @"C:\Chandra\Resumes";

            if (!Directory.Exists(BasePath))
            {
                Directory.CreateDirectory(BasePath);
            }

            string relativePath = @"Resumes\" + DateTime.Now.ToString("yyyMMdd");

            string filesToUpload = Path.Combine(BasePath, relativePath);

            if (!Directory.Exists(filesToUpload))
            {
                Directory.CreateDirectory(filesToUpload);
            }

            FileInfo[] files = new DirectoryInfo(filesToUpload).GetFiles();

            if (files != null)
                Console.WriteLine($"Total Files: {files.Length}");

            return View();
        }
    }
}
