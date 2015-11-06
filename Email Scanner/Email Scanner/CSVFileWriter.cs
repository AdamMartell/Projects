using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Email_Scanner
{
    class CSVFileWriter : IFileWriter
    {
        public void WriteFile(string[] text, string line, string fileName)
        {
            string filePath = @"C:\Users\amartell_be\Downloads" + fileName;
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
            string delimiter = ",";
            string[][] output = new string[][]{
            new string[]{"Value1","Value2","Value3","Value4"} /*add the values that you want inside a csv file. Mostly this function can be used in a foreach loop.*/
            };
            int length = output.GetLength(0);
            StringBuilder sb = new StringBuilder();
            for (int index = 0; index < length; index++)
                sb.AppendLine(string.Join(delimiter, output[index]));
            File.AppendAllText(filePath, sb.ToString());
        }
    }
}

