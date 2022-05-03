using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab2.BL
{
   public  class FileManager
    {
       public  int  PChipBlue { get; set; }
        public int PChipRed { get; set; }
        public int BChipBlue { get; set; }
        public int BChipRed { get; set; }
       
      
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
        public string Chary(string letter1, string letter2)
        {
            using (StreamReader streamReader = new StreamReader(@"C:\\Users\\Username\\Desktop\\writer.txt", System.Text.Encoding.Default))
            {
                string CountS= streamReader.ReadToEnd();
              
                int StartIndex = Convert.ToInt32(letter1);
               
                int LastIndex = Convert.ToInt32(letter2);
                
                string Numbers = CountS.Substring(StartIndex + 1, LastIndex-(StartIndex+1));

                
                return $"{Numbers}";
            }

        }

        }
    }

