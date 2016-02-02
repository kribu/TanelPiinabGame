using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanelPiinabGame{
    class Program{

        static void Main(string[] args){
            ///Console.WriteLine("Hello, Tanel!");
            var Monster1 = new Monster { Name = "Kristin", Lives = 50, HitValue = 4};
            var Monster2 = new Monster { Name = "Kiku", Lives = 50, HitValue = 3};
            var Monster3 = new Monster { Name = "Kaku", Lives = 50, HitValue = 10 };
            var Monster4 = new Monster { Name = "Taku", Lives = 50, HitValue = 7 };

            Monster1.Hit(Monster1, Monster2);            

        }
    }

    public class Monster{

        public string Name{
            get; set;
        }

        public int Lives{
            get; set;
        }

        public int HitValue{
            get; set;
        }

        public void Hit(Monster firstMonster, Monster secondMonster){

            while(firstMonster.Lives>0 && secondMonster.Lives > 0) { 
                Random rnd = new Random();
                int whoNext = rnd.Next(101);
                Console.WriteLine(whoNext); 

                if (whoNext % 2 == 0){
                    firstMonster.Lives = firstMonster.Lives - secondMonster.HitValue;
                    Console.WriteLine(firstMonster.Name + " has " + firstMonster.Lives + " lives left. (1)");
                    Console.WriteLine(secondMonster.Name + " has " + secondMonster.Lives + " lives left. (1)");
                }else {
                    secondMonster.Lives = secondMonster.Lives - firstMonster.HitValue;
                    Console.WriteLine(secondMonster.Name + " has " + secondMonster.Lives + " lives left. (2)");
                    Console.WriteLine(firstMonster.Name + " has " + firstMonster.Lives + " lives left. (2)");
                }

                if (firstMonster.Lives <= 0 || secondMonster.Lives <= 0){
                    Console.WriteLine("Game over!");
                    if (firstMonster.Lives > secondMonster.Lives){
                        Console.WriteLine(firstMonster.Name + " won!");
                    }else {
                        Console.WriteLine(secondMonster.Name + " won!");
                    }
                }
            }
        }
    }
}
