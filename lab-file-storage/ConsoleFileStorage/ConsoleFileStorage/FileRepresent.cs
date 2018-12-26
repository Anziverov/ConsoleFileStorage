using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFileStorage
{
    [Serializable]
    class FileRepresent
    {
        public string FileName { get; set; }
        public string FileExstension { get; set; }
        public int FileSize { get; set; }
        public DateTime CreationDate { get; set; }
        public byte[] FileHash { get; set; }
        public int DownloadsNumber { get; set; }
    }
}
