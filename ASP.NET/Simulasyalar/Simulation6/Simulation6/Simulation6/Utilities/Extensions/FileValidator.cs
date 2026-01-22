using Simulation6.Utilities.Enums;

namespace Simulation6.Utilities.Extensions
{
    public static class FileValidator
    {

        public static bool FileSizeValidator(IFormFile file, FileSize fileSize, int size)
        {
            switch (fileSize)
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

       
        public static void FileDelete(this string fileName, params string[] roots)
        {
          string path=String.Empty;
            for (int i = 0; i < roots.Length; i++)
            {
                path = Path.Combine(path, roots[i]);
            }
            path = Path.Combine(path, fileName);
            File.Delete(path);
           
        }

        public static bool FileTypeValidator(IFormFile file, string type)
        {
            if (file.ContentType.Contains(type))
            {
                return true;
            }
            return false;
        }

        public static async Task<string> FileCreate(this IFormFile file, params string[] roots)
        {
            string fileName = String.Concat(Guid.NewGuid().ToString(), file.FileName);
            string path = String.Empty;
            for (int i = 0; i < roots.Length; i++)
            {
                path = Path.Combine(path, roots[i]);
            }
            path = Path.Combine(path, fileName);


            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

            return fileName;
        }
    }
}
