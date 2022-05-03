using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtw
{
    class Class1
    {
        delegate void PKD(int a);
        event PKD ewg;
        public void Ebfv(int a)
        {
            if (a == 1)
                ewg?.Invoke(a);
            if (a == 2)
                ewg?.Invoke(a);


        }
        //public void EventsGame(int MyColor, int EnemyColor, Person person1, Person person2)
        //{

        //    switch (MyColor == 0 && EnemyColor == 0)
        //    {
        //        case true:
        //            if (person1.BlueChip + person1.RedChip > person2.BlueChip + person2.RedChip)
        //            {

        //                Notify?.Invoke(1);
        //            }
        //            if (person1.BlueChip + person1.RedChip < person2.BlueChip + person2.RedChip)
        //            {

        //                Notify?.Invoke(2);
        //            }
        //            if (person1.BlueChip + person1.RedChip == person2.BlueChip + person2.RedChip)
        //            {

        //                Notify?.Invoke(3);
        //            }
        //            else
        //            {
        //                Notify?.Invoke(0);
        //            }
        //            break;

        //        case false:
        //            Notify?.Invoke(0);
        //            break;
        //    }

        //}

    }
}
