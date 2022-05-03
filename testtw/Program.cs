using System;

namespace testtw
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.Notify += DisplayMessage;
            account.Put(20);
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(70);   // пытаемся снять со счета 70
            Console.WriteLine($"Сумма на счете: {account.Sum}");
            account.Take(180);  // пытаемся снять со счета 180
            Console.WriteLine($"Сумма на счете: {account.Sum}");

         

            void DisplayMessage(string message)=>Console.WriteLine(message);
        }
        class Account
        {
            public delegate void AccountHadnler(string message);
            public event AccountHadnler Notify;//1.определение события
            public Account(int sum) => sum = Sum;
            public int Sum { get; private set; }
            public void Put(int sum)
            {
                Sum += sum;
                Notify?.Invoke($"На счет поступило:{sum}");//2.ВЫзов события
            }
            public void Take(int sum)
            {
                if(Sum>=sum)
                {
                    Sum -= sum;
                    Notify?.Invoke($"Со счета снято :{sum}");

                }

                else
                {
                    Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс :{Sum}");
                }
            }
        }


    }
}
