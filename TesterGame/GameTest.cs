using System;
using System.Collections.Generic;

namespace LotteryGame
{
    class GameTest
    {
        static void Main(string[] args)
        {
            Lottery lottery = new Lottery();
            lottery.generateNumbers();
            Player player = new Player();
            //uncomment this to see the lottery numbers
            //lottery.printNumbers();
            player.setPlayerNumbers();
            BusinessLogicLoterry bl= new BusinessLogicLoterry(lottery, player);
            bl.checkIsWinner();
        }
    }
}
