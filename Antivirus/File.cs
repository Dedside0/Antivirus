using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antivirus
{
    class File
    {
        public string FileName { get; set; }
        public string UserName { get; set; }
        public int Size{ get; set; }


        public File(string filename, string userName, int size)
        {
            FileName = filename;
            UserName = userName;
            Size = size;
        }

        public override string ToString()
        {
            return $"{FileName} - {UserName} - {Size/(1024*8.0)} kb";
        }


    }
}
