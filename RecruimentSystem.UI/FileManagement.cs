using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystem.UI
{
    internal class FileManagement
    {
        public static void SaveFile(string fileName, string filePath)
        {
            if (!string.IsNullOrEmpty(fileName))
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var targetDirectory = string.Concat(currentDirectory, "/");
                var imagePath = string.Concat(targetDirectory, fileName);

                if (!Directory.Exists(targetDirectory))
                    Directory.CreateDirectory(targetDirectory);


                File.Copy(filePath, imagePath, true);
            }
        }
    }
}
