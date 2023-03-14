using System;
using System.IO;

namespace RecruitmentSystem.UI
{
    public class FilesWork
    {

        //public string imagePhysicalPath = default;
        //public string imageName = default;

        ////public static void SaveFile(string imagePath, string imageName)
        ////{
        ////    using Stream stream = new FileStream(imagePath, FileMode.Open);
        ////    using var memoryStream = new MemoryStream();
        ////    stream.CopyTo(memoryStream);

        ////    string directory = string.Concat(AppDomain.CurrentDomain.BaseDirectory);
        ////    if (!Directory.Exists(directory))
        ////        Directory.CreateDirectory(directory);

        ////   File.WriteAllBytes(string.Concat(directory, imageName), memoryStream.ToArray());

           
        ////}
        //public void SaveImagePath()
        //{
        //    if (!string.IsNullOrEmpty(imageName))
        //    {
        //        var currentDirectory = Directory.GetCurrentDirectory();
        //        var targetDirectory = string.Concat(currentDirectory, "/");
        //        var imagePath = string.Concat(targetDirectory, imageName);

        //        if (!Directory.Exists(targetDirectory))
        //            Directory.CreateDirectory(targetDirectory);


        //        File.Copy(imagePhysicalPath, imagePath, true);
        //    }
        //}
    }
}
