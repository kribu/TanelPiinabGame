using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: okei, kasuta sellist sulgude stiili, aga for gods sake pane tühik nime ja sulu vahele
//       sa jätsid selle TODO siia ainult sellepärast, et mind närvi ajada...
//       JEP :D kuidagi pean mina ka sind kiusama :D

namespace TanelPiinabGame{
    class Program{

        static void Main(string[] args){
            var monsters = new List<Monster>(){
                new Monster { Name = "Kristin", Health = 50, HitValue = 4},
                new Monster { Name = "Kiku", Health = 50, HitValue = 3},
                new Monster { Name = "Kaku", Health = 50, HitValue = 10 },
                new Monster { Name = "Taku", Health = 50, HitValue = 7 }
            };
            Fight(monsters[0], monsters[1]);
        }

        static void Fight(Monster fmonster, Monster smonster){
            Random rnd = new Random();
            while (fmonster.IsAlive(fmonster) && smonster.IsAlive(smonster)){
                int whoNext = rnd.Next(101);
                Console.WriteLine($"{whoNext}");
                if (whoNext % 2 == 0){
                    fmonster.Hit(smonster);
                }else{
                    smonster.Hit(fmonster);
                }
                Console.WriteLine($"{fmonster.Name}  has {fmonster.Health} lives left and {smonster.Name} has {smonster.Health} lives left");
            }
        
            Console.WriteLine($"Game over");
            if (fmonster.Health > smonster.Health){ 
                Console.WriteLine($"{fmonster.Name} won!");
            }else{
                Console.WriteLine($"{smonster.Name} won!");
            }
        }
    }
}


