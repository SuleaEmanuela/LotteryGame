using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryGame
{
    class Lottery
    {
       
        public List<int> ListOfNumbers { get; set; }
       
        public Lottery()
        {
            ListOfNumbers = new List<int>();
        }

       
        public void printNumbers()
        {
            Console.Write("\nLottery numbers : ");
            foreach (int number in ListOfNumbers)
            {
                Console.Write(number+" ");
            }
        }

        public  List<int> generateNumbers()
        {
            Random randObj = new Random();

            for (int index = 0; index < 6; index++)
            {
                ListOfNumbers.Add(randObj.Next(1, 10));
            }
            return ListOfNumbers;
        }


    }
}
