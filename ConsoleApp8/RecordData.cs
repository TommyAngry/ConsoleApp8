using System;
namespace Lab2.BL
{
    public class RecordData
    {
       
      
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
      
       public void ChipsCountStart()
        {
            FileManager fMPeopleBlue = new();


            a = Convert.ToInt32(fMPeopleBlue.Chary("B","P")); //Blue People
            FileManager fMBotBlue = new();
            b = Convert.ToInt32(fMBotBlue.Chary("b", "M"));//blue machine
            FileManager fMPeopleRed = new();
            c = Convert.ToInt32(fMPeopleRed.Chary("p", "R"));//people Red
            FileManager fMBotRed = new();
            d = Convert.ToInt32(fMBotRed.Chary("m", "r"));//machine red
        }
    }
     
}