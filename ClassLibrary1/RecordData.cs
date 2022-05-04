using System;
namespace ClassLibrary1
{
    public class RecordData
    {
       
      
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public int e { get; set; }
        public int f { get; set; }
        /// <summary>
        /// a-фишки цвета человека, b-количество фишек своего цвета у игрока, с- количество фишек вражеских у человека, d-количество фишек бота, e- количесвто фишек своего цвета у юота
        /// f- количество фишек вражуских у бота
        /// </summary>
        public void ChipsCountStart()
        {
            FileManager fMPeopleBlue = new();


            a = Convert.ToInt32(fMPeopleBlue.Chary('B', 'C')); //Blue Colour
            FileManager fMBotBlue = new();
            b = Convert.ToInt32(fMBotBlue.Chary('P', 'B'));//people Blue
            FileManager fMPeopleRed = new();
            c = Convert.ToInt32(fMPeopleRed.Chary('p', 'R'));//people Red
            FileManager fMBotRed = new();
            d = Convert.ToInt32(fMBotRed.Chary('M', 'r'));//machine red
            FileManager fMBotRedColour = new();
            e = Convert.ToInt32(fMBotRed.Chary('m', 'r'));//machine red
            FileManager bot_enemy = new();
            f = Convert.ToInt32(fMBotRed.Chary('b', 'e'));//bot enemy

        }
    }
    }
     
