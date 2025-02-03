using System.IO;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string BasePath = @"C:\Chandra\Resumes";

if(!Directory.Exists(BasePath))
{
    Directory.CreateDirectory(BasePath);
}

string relativePath = @"Resumes\" + DateTime.Now.ToString("yyyMMdd");

string filesToUpload = Path.Combine(BasePath, relativePath);

if (!Directory.Exists(filesToUpload))
{
    Directory.CreateDirectory(filesToUpload);
}

FileInfo[] files =  new DirectoryInfo(filesToUpload).GetFiles();

if (files != null)
    Console.WriteLine($"Total Files: {files.Length}");