using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: okei, kasuta sellist sulgude stiili, aga for gods sake pane tühik nime ja sulu vahele
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
            while (fmonster.isAlive(fmonster) && smonster.isAlive(smonster)){
               Hit(fmonster, smonster); //error error error error error
            }
            Console.WriteLine($"Game over");
            if (fmonster.Health > smonster.Health)
            {
                Console.WriteLine($"{fmonster.Name} won!");
            }else {
                Console.WriteLine($"{smonster.Name} won!");
            }

                
    }


}
