using System;
using System.IO;
using System.Net;

namespace RpLibs
{
    public class Web
    {

        public void pullFile(string URLlocation, string FName, string Folder)
        {

            string remoteUri = URLlocation;
            string fileName = FName, myStringWebResource = null;
            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            Console.WriteLine("Downloading File \"{0}\" from \"{1}\" .......\n\n", fileName, myStringWebResource);
            // Download the Web resource and save it into the current filesystem folder.
            myWebClient.DownloadFile(myStringWebResource, fileName);
            Console.WriteLine("Successfully Downloaded File \"{0}\" from \"{1}\"", fileName, myStringWebResource);
            Console.WriteLine("\nDownloaded file saved in the following file system folder:\n\t" + Folder);

        }

        public static string pullContent(string url)
        {

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            reader.Close();
            return content;

        }

        public byte[] PullFile(string url)
        {
            using (WebClient client = new WebClient())
            {
                return client.DownloadData(url);
            }
        }

        public static string PullContent(string url)
        {

            string fileContent = new WebClient().DownloadString(url);
            return fileContent;
        }
    }
    public class Files
    {

        public static string read(string location, string FName)
        {

            string content = File.ReadAllText(location + FName);
            return content;

        }

        public static string write(string location, string FName, string content)
        {

            File.WriteAllText(location + FName, content);
            return $"{FName} created at {location}";

        }

        public static string exists(string location, string FName)
        {

            bool FileExist = File.Exists(location + FName);
            return FileExist.ToString();

        }
    }
}