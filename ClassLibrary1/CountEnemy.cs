﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class CountEnemy
    {
        /// <summary>
        /// сколько у меня фишек врага
        /// </summary>
       public int EnemyMy { get; set; }
        /// <summary>
        /// сколько фишек вражеских у врага
        /// </summary>
        public int EnemyChips { get; set; }
       public CountEnemy(int myColour,int myChip,int enemyColour,int MyenemyChip)
       {
            if(myColour+myChip!=7)
            {
                EnemyMy = 7-(myColour + myChip);
            }
            else { EnemyMy = 0; }
            if(enemyColour+MyenemyChip!=7)
            {
                EnemyChips = 7 - (enemyColour + MyenemyChip);
            }
            else { EnemyChips = 0; }
       }
    }
}
