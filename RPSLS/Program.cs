using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Human playerOne = new Human("Austin");
            Human playerTwo = new Human("Playertwo");
            CPU cpuPlayer = new CPU("Computer");
            PlayersList playerList = new PlayersList();
            playerList.AddPlayer(playerOne);
            playerList.AddPlayer(playerTwo);
            playerList.AddPlayer(cpuPlayer);
            playerList.ListCount();
            Game rpsls = new Game();
            rpsls.WelcomeMessage();
            rpsls.SelectMode();
        }
    }
}
