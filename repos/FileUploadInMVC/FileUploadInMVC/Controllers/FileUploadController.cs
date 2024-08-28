using Microsoft.AspNetCore.Mvc;

namespace FileUploadInMVC.Controllers
{
    public class FileUploadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [RequestSizeLimit(15000000)]
        public async Task<IActionResult> SingleFileUpload(IFormFile SingleFile)
        {
            var permittedExtensions = new[] { ".jpg", ".png", ".gif" };
            var extension = Path.GetExtension(SingleFile.FileName).ToLowerInvariant();
            if (string.IsNullOrEmpty(extension) || !permittedExtensions.Contains(extension))
            {
                ModelState.AddModelError("", "Invalid file type.");
            }
            if (ModelState.IsValid)
            {
              

                if (SingleFile != null && SingleFile.Length > 0)
                {
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", SingleFile.FileName);
                    //Using Buffering
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        // The file is saved in a buffer before being processed
                        await SingleFile.CopyToAsync(stream);
                    }
                    //Using Streaming
                    //using (var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                    //{
                    //    await SingleFile.CopyToAsync(stream);
                    //}
                    // Process the file here (e.g., save to the database, storage, etc.)
                    return View("UploadSuccess");
                }
            }
            return View("Index");
        }
    }
}

