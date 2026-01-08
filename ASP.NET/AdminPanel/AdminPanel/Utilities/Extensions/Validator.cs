using AdminPanel.Utilities.Enums;
using Microsoft.AspNetCore.StaticFiles;

namespace AdminPanel.Utilities.Extensions
{
    public static class Validator
    {
        public static bool FileTypeValidator(IFormFile file, string type)
        {
            if (file.ContentType.Contains(type))
            {
                return true;
            }
            return false;
        }

        public static bool FileSizeValidator(IFormFile file, FileSize fileSize, int size)
        {
            switch (fileSize)
            {
                case FileSize.KB:
                    return file.Length <= size * 1014;
                case FileSize.MB:
                    return file.Length <= size * 1014 * 1024;
                case FileSize.GB:
                    return file.Length <= size * 1014 * 1024 * 1024;
              

            }
            return false;
        }
    }
}
