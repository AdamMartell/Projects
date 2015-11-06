using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Scanner
{
    public interface IFileWriter
    {
        void WriteFile(string[] text, string line, string fileName);
    }
}
