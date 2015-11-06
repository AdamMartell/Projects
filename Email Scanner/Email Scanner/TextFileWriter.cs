using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Scanner
{
    class TextFileWriter : IFileWriter
    {
        public void WriteFile(string[] text, string line, string fileName)
        {
            string[] log = { text[0], text[1], text[2], line };
            File.AppendAllLines(@"C:\Users\amartell_be\Downloads\" + fileName, log);
        }
    }
}
