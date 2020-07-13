using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht3Versleutelen
{
    class ToFileWriter
    {
        private string filePath;
        private List<string> fileText;

        public ToFileWriter(string filePath)
        {
            this.filePath = filePath;
            if (File.Exists(filePath))
            {
                fileText = ArrayToList(File.ReadAllLines(filePath));
            }
            else
            {
                fileText = new List<string>();
            }
        }

        public void StringToFile(string text)
        {
            AddStringToText(text);
            TextToFile();
        }

        public void AddStringToText(string text)
        {
            fileText.Add(text);
        }
        public void TextToFile()
        {
            System.IO.File.WriteAllLines(filePath,ListToArray(fileText));
        }

        private string[] ListToArray(List<string> list)
        {
            string[] array = new string[list.Count()];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = list[i];
            }
            return array;
        }
        private List<string> ArrayToList(string[] array)
        {
            List<string> list = new List<string>();
            for(int i = 0; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            return list;
        }
    }
}
