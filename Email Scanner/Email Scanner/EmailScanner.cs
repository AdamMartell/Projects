using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

namespace Email_Scanner
{
    class EmailScanner
    {
        private string[] emails;
        private List<string[]> keywords;
        private string flaggedLine;
        private string[] flaggedEmail;
        private string logType;
        private string fileName;

        public string[] FlaggedEmail
        {
            get { return flaggedEmail; }
            set
            {
                flaggedEmail = value;
                OnValueChanged();
            }
        }
        public string LogType
        {
            get { return logType; }
        }
        public string FlaggedLine
        {
            get { return flaggedLine; }
        }
        public string FileName
        {
            get { return fileName; }
        }
        public void ConfigurateScanner(string fileName)
        {
            keywords = new List<string[]>() { };
            string[] lines = File.ReadAllLines(fileName);
            emails = lines[0].Split(',');
            for (int x = 1; x < lines.Length; x++)
            {
                keywords.Add(lines[x].Split(','));
            }
        }
        public void ScanEmail()
        {
            foreach (string email in emails)
            {
                string[] lines = File.ReadAllLines(email);
                foreach (string line in lines)
                {
                    foreach (string[] array in keywords)
                    {
                        fileName = array[0];
                        logType = array[0].Substring(array[0].IndexOf('.')).ToLower();
                        LookForKeywords(array, line, lines);
                    }
                }
            }
        }
        public void LookForKeywords(string[] keyWordList, string line, string[] lines)
        {
            foreach (string keyword in keyWordList)
            {
                if (line.Contains(keyword))
                {
                    flaggedLine = line;
                    FlaggedEmail = lines;
                }
            }
        }
        public event EventHandler ValueChanged;

        protected void OnValueChanged()
        {
            if (ValueChanged != null)
                ValueChanged(this, EventArgs.Empty);
        }
    }
}
