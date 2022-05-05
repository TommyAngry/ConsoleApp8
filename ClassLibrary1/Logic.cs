using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Logic
    {
        /// <summary>
        /// //отвечает за то что будет на кубиках
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 

            public void Variant(int a)
            {
               
                RecordData recordData = new();
                recordData.ChipsCountStart();
                switch (a != 1)
                {
                    case true:
                        Game(recordData.a, recordData.b, recordData.c, recordData.d, a);
                    break;
                    

                    case false:
                        Game(recordData.c, recordData.d, recordData.a, recordData.b,a);
                    break;
                    
                }
            }    
        public int Rand(int a, int b)
        {
            Random random = new Random();

            int Cube = random.Next(a, b);
            
            return Cube;
        }
        public delegate string AccountHandler(int a);
        public event AccountHandler Notify;
        FileManager fileManager = new();

        /// <summary>
        /// с помощью этого метода идет выборка в каком порядке вбивать параметры
        /// </summary>
        /// <param name="a">отвечает за правильную запись в докумени, если 0-bot,если 1-человек</param>

        public void Game(int PeopleColor, int PHaveChip, int BotColor,int BHaveChip,int a)
        {
            int RandA = Rand(1, 6); int RandB = Rand(1, 6);
            switch (RandA != RandB)
            {
                case true:
                    if (PeopleColor != 0)
                    {
                        int res = Chips(RandA, RandB);
                        if (PeopleColor < res)
                        {
                            PHaveChip += PeopleColor;
                            PeopleColor -= PeopleColor;
                            Rec(a, PeopleColor, PHaveChip, BotColor, BHaveChip);
                            break;
                            
                        }
                        else if (PeopleColor > res)
                        {
                            PeopleColor -= res;
                            PHaveChip += res;
                            Rec(a, PeopleColor, PHaveChip, BotColor, BHaveChip);
                            break;
                        }
                    }
                    break;
                  

                case false:
                    if (BotColor != 0)
                    {
                        if (BotColor > RandA)
                        {
                            BotColor -= RandA;
                            BHaveChip += RandA;
                            Rec(a, PeopleColor, PHaveChip, BotColor, BHaveChip);
                            break;
                        }
                       else if (BotColor < RandA)
                        {
                            BHaveChip += BotColor;
                            BotColor -= BotColor;
                            Rec(a, PeopleColor, PHaveChip, BotColor, BHaveChip);
                            break;
                        }
                    }

                    break;
            }

        }
        /// <summary>
        /// передаются данные из логики(game)для выбора как записать
        /// </summary>
        /// <param name="a"></param>
        /// <param name="PeopleColor"></param>
        /// <param name="PHaveChip"></param>
        /// <param name="BotColor"></param>
        /// <param name="BHaveChip"></param>
        ///   
        People people = new People();
        Bot bot = new();

        void Rec(int a, int PeopleColor, int PHaveChip, int BotColor, int BHaveChip)
        {
            if (a == 0)
            {
                //бот
              
                CountEnemy countEnemy = new(PeopleColor, PHaveChip, BotColor, BHaveChip);
                fileManager.FileData(BotColor, BHaveChip, countEnemy.EnemyChips, PeopleColor, PHaveChip, countEnemy.EnemyMy);
                people.MyChip = BHaveChip;
                people.EnemyChip = countEnemy.EnemyChips;
                bot.MyChip = PHaveChip;
                bot.EnemyChip = countEnemy.EnemyMy;
              

            }
            if (a == 1)
            {
                ///человек
                CountEnemy countEnemy = new(PeopleColor, PHaveChip, BotColor, BHaveChip);
                fileManager.FileData(PeopleColor, PHaveChip, countEnemy.EnemyMy, BotColor, BHaveChip, countEnemy.EnemyChips);
                people.MyChip = PHaveChip;
                people.EnemyChip = countEnemy.EnemyMy;
                bot.MyChip = BHaveChip;
                bot.EnemyChip = countEnemy.EnemyChips;

            }


        }
        /// <summary>
        /// работак с кубикамиЮ какие фишки брать, своего или чужого цвета
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private static int Chips(int a,int b)
        {
            int result;
            switch (a > b)
            {
                case true:
                    result = a - b;
                    return result;
                case false:
                    result = b - a;
                    return result;
            }

        }
        /// <summary>
        /// События
        /// </summary>
        /// <param name="MyColor"></param>
        /// <param name="EnemyColor"></param>
        /// <param name="person1"></param>
        /// <param name="person2"></param>
        public void  EventsGame(int MyColor,int EnemyColor,Person person1,Person person2)
        {
      
            switch (MyColor ==0 && EnemyColor == 0)
            {
                case true:
                    if(person1.MyChip+person1.EnemyChip>person2.MyChip+person2.EnemyChip)
                    {
                      
                         Notify?.Invoke(1);
                    }
                    if(person1.MyChip + person1.EnemyChip < person2.MyChip + person2.EnemyChip)
                    {

                         Notify?.Invoke(2);
                    }
                    if (person1.MyChip + person1.EnemyChip == person2.MyChip + person2.EnemyChip)
                    {

                         Notify?.Invoke(3);
                    }                   
                    break;

                case false:                   
                     Notify?.Invoke(0);
                    break;
            }

        }
     
        
       
    
    
    }



}
