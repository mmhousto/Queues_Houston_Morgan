using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Houston_Morgan
{
    class Game
    {

        public int MaxPlayers { get; }

        public int CurrentPlayers { get; set; }

        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        public void CheckQueue(Queue<Player> playerQueue)
        {
            if(CurrentPlayers < MaxPlayers)
            {
                if(playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }


    }
}
