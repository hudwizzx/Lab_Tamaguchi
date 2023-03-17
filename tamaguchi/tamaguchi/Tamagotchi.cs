using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamaguchi
{
    public class Tamagotchi
    {
        private string name;
        private int hunger;
        private int happiness;

        public Tamagotchi(string name)
        {
            this.name = name;
            this.hunger = 0;
            this.happiness = 0;
        }

        public void Feed()
        {
            this.hunger -= 10;
            if (this.hunger < 0)
            {
                this.hunger = 0;
            }
            this.happiness += 5;
        }

        public void Play()
        {
            this.hunger += 5;
            this.happiness += 10;
        }

        public void Sleep()
        {
            this.hunger += 5;
            this.happiness -= 5;
        }

        public void PrintStats()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Hunger: " + this.hunger);
            Console.WriteLine("Happiness: " + this.happiness);
        }
    }
}
