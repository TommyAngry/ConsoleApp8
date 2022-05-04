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
        public int Rand(int a, int b)
        {
            Random random = new Random();

            int Cube = random.Next(a, b);
            Console.WriteLine(a & b);
            return Cube;
        }
        public delegate string AccountHandler(int a);
        public event AccountHandler Notify;
        /// <summary>
        /// отвечает за изменения у игрока количества фишек
        /// </summary>
        /// <param name="myColor"></param>
        /// <param name="enemyColor"></param>
        /// <param name="myChip"></param>
        /// <param name="enemyChip"></param>
        /// <param name="RandA"></param>
        /// <param name="RandB"></param>
        /// <returns></returns>
        /// 
       
        /// <summary>
        /// с помощью этого метода идет выборка в каком порядке вбивать параметры
        /// </summary>
        /// <param name="a"></param>
        public void Variant(int a)
        {
             RecordData recordData = new();
            recordData.ChipsCountStart();
            switch (a != 1)
            {
                case true: Game(recordData.a,recordData.b, recordData.c, recordData.d);
                    break;
                
                case false: Game(recordData.c, recordData.d, recordData.a, recordData.b);
                    break;
            }
        }
        FileManager fileManager = new();
        public int Game(int myColor, int enemyColor, int myChip, int enemyChip)
        {
            int RandA = Rand(1, 6); int RandB = Rand(1, 6);
            switch (RandA != RandB)
            {
                case true:
                    if (myColor != 0)
                    {
                        int res = Chips(RandA, RandB);
                        if (myColor < res)
                        {
                            myChip += myColor;
                            myColor -= myColor;
                        }
                        if (myColor > res)
                        {
                            myColor -= res;
                            myChip += res;
                        }
                    }
                    fileManager.FileData(myColor, myChip, enemyColor, enemyChip);

                    return myChip;

                case false:
                    if (enemyColor != 0)
                    {
                        if (enemyColor > RandA)
                        {
                            enemyColor -= RandA;
                            enemyChip += RandA;

                        }
                        if (enemyColor < RandA)
                        {
                            enemyChip += enemyColor;
                            enemyColor -= enemyColor;
                        }
                    }
                     fileManager.FileData(myColor, myChip, enemyColor, enemyChip);
                  
                    return enemyChip;
            }

        }
        /// <summary>
        /// с помощью этого метода идет запись результатов
        /// </summary>
        /// <param name="myColor"></param>
        /// <param name="enemyColor"></param>
        /// <param name="myChip"></param>
        /// <param name="enemyChip"></param>
        /// <param name="a"></param>
       
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
