using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace ConsoleFileStorage
{
    class MetaInformationKeeper // rename , delete , downloaded
    {
        List<FileRepresent> fileRepresentsList = new List<FileRepresent>();
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        private string pathToMetaFile;
        public MetaInformationKeeper( string p_pathToMetaFile)
        {
            pathToMetaFile = p_pathToMetaFile;
            ReadMetaFile();
        }
        public void UploadFile(string filePath)
        {
            FileRepresent fileRepresent = new FileRepresent();
            using (FileStream fs = File.OpenRead(filePath))
            {
                HashAlgorithm hash = SHA256.Create();
                fileRepresent.FileHash = hash.ComputeHash(fs);
                var temps = filePath.Split('\\');
                var name = temps[temps.Length - 1].Split('.');
                fileRepresent.FileName = name[0];
                fileRepresent.FileExstension = name[1];
            }
            fileRepresentsList.Add(fileRepresent);
            WriteChangesToMetaFile();
        }
        public void WriteChangesToMetaFile()
        {
            using (FileStream fs = new FileStream(pathToMetaFile, FileMode.Create))
            {
                binaryFormatter.Serialize(fs, fileRepresentsList);
            }
        }
        public void ReadMetaFile()
        {
            using(FileStream fs = new FileStream(pathToMetaFile, FileMode.Open))
            {
                fileRepresentsList = binaryFormatter.Deserialize(fs) as List<FileRepresent>;
            }
        }

        
    }
}
