using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Scanner
{
    class FileWriterFactory
    {
        public static IFileWriter GetFileWriter(string fileExtension)
        {
            IFileWriter fileWriter = null;
            switch (fileExtension){
                case ".txt":
                    fileWriter = new TextFileWriter();
                    break;
                case ".csv":
                    fileWriter = new CSVFileWriter();
                    break;
                case ".xml":
                    fileWriter = new XMLFileWriter();
                    break;
                default:
                    return null;
            }
            return fileWriter;
        }
    }
}
