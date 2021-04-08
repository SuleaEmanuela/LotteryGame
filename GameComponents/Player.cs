using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryGame
{ 
    class Player
    {
       public List<int> ListOfNumbers { get; set; }
       public Player()
        {
            ListOfNumbers= new List<int>();
        }

        public  void setPlayerNumbers()
        {
            string number;
            Console.WriteLine("Type the lucky numbers for this lottery game:");
            for (int index = 0; index < 6; index++)
            {
                number = Console.ReadLine();

                if (inputCondition(Convert.ToInt32(number)) == true)
                {
                    ListOfNumbers.Add(Convert.ToInt32(number));
                }
                else
                {
                    Console.WriteLine("The number is not valid!\nTry again with a number from [1,10].\n");
                    number = Console.ReadLine();
                    ListOfNumbers.Add(Convert.ToInt32(number));
                }
            }
        }

        public  bool inputCondition(int number)
        {
            if (number <= 10 && number >= 1)
            {
                return true;
            }
            else
                return false;
        }
        public void printNumbers()
        {
            Console.Write("\nPlayer numbers : ");
            foreach (int number in ListOfNumbers)
            {
                Console.Write(number + " ");
            }
        }

    }
}
