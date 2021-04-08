using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryGame
{
    class BusinessLogicLoterry
    {
        public Lottery lottery { get; set; }
        public Player player  { get; set; }
        public BusinessLogicLoterry(Lottery lottery, Player player)
        {
            this.lottery = lottery;
            this.player = player;
        }

        public bool winningCondition()
        {
            foreach (int number in player.ListOfNumbers)
            {
                if (lottery.ListOfNumbers.Contains(number) == true)
                {
                    continue;
                }
                else
                    return false;
            }
            return true;
        }

        public void checkIsWinner()
        {
            if (winningCondition() == true)
            {
                Console.WriteLine("You have guessed the numbers!Good job!You are the winner!Here is the proof:");
                lottery.printNumbers();
                player.printNumbers();
            }
            else
            {
                Console.WriteLine("You have not guessed the numbers!Bad luck:( Here is the proof : ");
                lottery.printNumbers();
                player.printNumbers();
            }
        }
    }
}
