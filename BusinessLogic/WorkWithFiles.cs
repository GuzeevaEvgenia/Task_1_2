using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace BusinessLogic
{
    public class WorkWithFiles

    {
        public string Input_File { get; set; }
        public string[] Text { get; set; }

        public WorkWithFiles()
        {

        }

        public WorkWithFiles(string InputFile)
        {
            Input_File = InputFile;
            Text = ReadFrom(Input_File);
        }

        public void WriteTo(string FileName, string[] arr)
        {
            using (StreamWriter file = new StreamWriter(FileName))
                for (int i = 0; i < arr.Length; i++)
                    file.WriteLine(arr[i]);
        }
        public string[] ReadFrom(string FileName)
        {
            string[] str1 = File.ReadAllLines(FileName, Encoding.Default);
            return str1;
        }

        public string CompareText(string s1, string s2)
        {
            string New = s1 + s2;
            return New;
        }

    }
}

