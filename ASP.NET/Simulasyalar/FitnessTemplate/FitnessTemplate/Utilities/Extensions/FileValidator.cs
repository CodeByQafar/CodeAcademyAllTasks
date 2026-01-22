using FitnessTemplate.Models;
using FitnessTemplate.Utilities.Enums;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace FitnessTemplate.Utilities.Extensions
{
    public static class FileValidator
    {


        static public bool FileSizeValidator(IFormFile file, FileSize sizeType, int size)
        {
            switch (sizeType)
            {
                case (FileSize.GB):
                    return file.Length < size * 1024 * 1024 * 1024;
                case (FileSize.MB):
                    return file.Length < size * 1024 * 1024;
                case (FileSize.KB):
                    return file.Length < size * 1024;

            }
            return false;
        }
        static public bool FileTypeValidator(IFormFile file, string fileType)
        {
            if (file.ContentType.Contains(fileType))
            {
                return true;

            }
            return false;
        }
        static public async Task<string> FileCreate(this IFormFile file, params string[] root)
        {
            string fileName = String.Concat(Guid.NewGuid().ToString(), file.FileName);
            string path = string.Empty;
            for (int i = 0; i < root.Length; i++)
            {
                path = Path.Combine(path, root[i]);
            }
            path = Path.Combine(path, fileName);
            using (FileStream fileStrem = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fileStrem);
            }
            return file.FileName;
        }

          public async static void DeleteFile (this string filename,params string[] roots)
        {

             // /Users/gulshanzalova/Desktop/MVCProjects-APA/ProniaApp/wwwroot/assets/images/website-images/7a655849-05b1-48d0-83c7-5cbdf240336amy_flower.jpeg
             string path= string.Empty;
             
             for(int i = 0; i < roots.Length; i++)
            {
                path=Path.Combine(path,roots[i]);
            }

              path=Path.Combine(path,filename);

              File.Delete(path);
        }
        //string fileName = String.Concat(Guid.NewGuid().ToString(), trainer.ImageFile.FileName);
        //string path = Path.Combine(_env.WebRootPath, "images", fileName);
        //FileStream stream = new FileStream(path, FileMode.Create);
        //await trainer.ImageFile.CopyToAsync(stream);
        //stream.Close();
        //    trainer.ImageUrl = fileName;
    }
}
