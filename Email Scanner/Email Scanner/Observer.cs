using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Email_Scanner
{
    class Observer
    {
        public Observer(EmailScanner subject)
        {
            subject.ValueChanged += subject_ValueChanged;
        }

        void subject_ValueChanged(Object sender, EventArgs e)
        {
            FileWriterFactory.GetFileWriter(((EmailScanner)sender).LogType).WriteFile(((EmailScanner)sender).FlaggedEmail, ((EmailScanner)sender).FlaggedLine, ((EmailScanner)sender).FileName);
        }
    }
}
