using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    internal class Player
    {
        public string Name { get; }
        public int Score { get; private set; }

        public Player(string name)
        {
            this.Name = name;
            Score = 0;
        }


        public int Hit() {
            // karty 2...10 = hodnota 2...10
            // J, Q, K = 10
            // A = 11;
            int randomKarta = new Random().Next(2, 12);
            Score += randomKarta;
            return randomKarta;
        }

        public void Stand() { 
            
        }
    }
}
