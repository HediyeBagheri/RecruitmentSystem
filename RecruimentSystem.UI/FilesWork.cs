using System;
using System.IO;

namespace RecruitmentSystem.UI
{
    public class FilesWork
    {
        public void SaveFile(string imagePath, string imageName)
        {
            using Stream stream = new FileStream(imagePath, FileMode.Open);
            using var memoryStream = new MemoryStream();
            stream.CopyTo(memoryStream);

            string directory = string.Concat(AppDomain.CurrentDomain.BaseDirectory);
            if (!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllBytes(string.Concat(directory, imageName), memoryStream.ToArray());
        }
    }
}
