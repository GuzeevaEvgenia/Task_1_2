using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.IO;

namespace BusinessLogic
{
    public class ShowItems
    {
        public string Input_File { get; set; }

        public int[] St { get; set; }

        public ShowItems()
        {

        }

        public ShowItems(string InputFile)
        {
            Input_File = InputFile;
            St = ReadFrom(Input_File);
        }
        public void WriteTo(string FileName, string[] st)
        {
            using (StreamWriter file = new StreamWriter(FileName))
                for (int i = 0; i < st.Length; i++)
                    file.WriteLine(st[i]);
        }
        public int[] ReadFrom(string FileName)
        {
            string[] str1 = File.ReadAllText(FileName, Encoding.Default).Split(new string[] { " ", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int[] result = new int[str1.Length];

            for (int i = 0; i < result.Length; i++)
                result[i] = int.Parse(str1[i]);

            return result;
        }


        public List<int> Show(List<int> list)
        {
            list.Add(St[0]);
            list.Add(St[1]);
            list.Add(St[St.Length - 2]);
            list.Add(St[St.Length - 1]);
            return list;
        }


    }
}
