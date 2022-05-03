using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ClassLibrary1
{
   public  class FileManager
    {
      
       
      
        public  void FileData(int a,int b, int c,int d)
        {

           
            using (StreamWriter sr = new StreamWriter(@"C:\\Users\\Username\\Desktop\\writer.txt",
                false, Encoding.Default))
            {
                sr.WriteLine($"B{a}P\nb{b}M\np{c}R\nm{d}r");
            }
            
           
        }

        /// <summary>
        /// Метод который берет значение числа из файла по координатам
        /// </summary>
        /// <param name="letter1"></param>
        /// <param name="letter2"></param>
        /// <returns></returns>
        public string Chary(char letter1, char letter2)
        {
            using (StreamReader streamReader = new StreamReader(@"C:\\Users\\Username\\Desktop\\writer.txt", System.Text.Encoding.Default))
            {
                string CountS = streamReader.ReadToEnd();
                string startletters = Convert.ToString(CountS.IndexOf(letter1));
                int StartIndex = Convert.ToInt32(startletters);

                string lastLetters = Convert.ToString(CountS.LastIndexOf(letter2));
                int LastIndex = Convert.ToInt32(lastLetters);

                string Numbers = CountS.Substring(StartIndex + 1, LastIndex - (StartIndex + 1));


                return $"{Numbers}";

            }


        }

    }
    }

