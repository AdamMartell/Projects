using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Email_Scanner
{
    class XMLFileWriter: IFileWriter
    {
        public void WriteFile(string[] text, string line, string fileName)
        {
            using (XmlWriter writer = XmlWriter.Create(@"C:\Users\amartell_be\Downloads\" + fileName))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Email");

                for (int x = 0; x <= 2; x++ )
                {
                    writer.WriteElementString("Metadata", text[x]);
                }
                writer.WriteElementString("Flagged-Line", line);
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
