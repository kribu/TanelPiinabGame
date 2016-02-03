using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// TODO: okei, kasuta sellist sulgude stiili, aga for gods sake pane tühik nime ja sulu vahele
namespace TanelPiinabGame{
    class Program{

        static void Main(string[] args){
            
            // TODO: muutujanimed on IGAL POOL väikse tähega ala "monster1"
            // TODO: kui sa kollide muutujatele mõistlikku nime ei suuda mõelda,
            //       siis see on vihje, et võiks kasutusele võtta var kollid = new List<Monster>() { new Monster { ... }, new Monster {... }, ... };
            //       neid kolle saad kätte nt kollid[0], et meetodisse anda
            var Monster1 = new Monster { Name = "Kristin", Lives = 50, HitValue = 4};
            var Monster2 = new Monster { Name = "Kiku", Lives = 50, HitValue = 3};
            var Monster3 = new Monster { Name = "Kaku", Lives = 50, HitValue = 10 };
            var Monster4 = new Monster { Name = "Taku", Lives = 50, HitValue = 7 };

            // TODO: üsna segane nimetus, ma tahaks arvata, et üks koll lööb teist, aga nad materdavad lõpuni välja,
            //       äkki oleks mõistlik teha uus meetod "Fight()", mille argumentideks on 2 kolli ja siis nad kaklevad lõpuni
            Monster1.Hit(Monster1, Monster2);            
        }

        // TODO: kui sa Fight meetodit plaanid, siis see tuleks siia teha signatuuriga:
        //       void Fight(Monster left, Monster right) { ... }
    }

    // TODO: see tuleks eraldi faili liigutada
    public class Monster{

        public string Name{
            get; set;
        }

        // TODO: parem nimetus võiks olla nt "Health"
        public int Lives{
            get; set;
        }

        public int HitValue{
            get; set;
        }

        // TODO: selle meetodi signatuur peaks olema ainult void Hit(Monster otherMonster) { ... }
        //       sest sa juba oled lööja kolli sees ja sa ei pea teda eraldi firstMonsterina passima,
        //       sa saad otse tema muutujatele ligi while (Lives > 0 && otherMonster.Lives > 0)
        //       kui see sulle segane on, siis saab selguse mõttes kasutada while (this.Lives > 0 && otherMonster.Lives > 0)
        // TODO: see meetod peaks tegelema ainult teise kolli löömisega, selline "fight" loogika tuleks mujale kolida
        public void Hit(Monster firstMonster, Monster secondMonster){

            // TODO: selle jaoks on Monsterisse ilus teha uus IsAlive() meetod või readonly property public bool IsAlive { get { return Lives > 0; } }
            while(firstMonster.Lives>0 && secondMonster.Lives > 0) { 
                Random rnd = new Random(); // TODO: mõistlikum on enne loopi rnd jada välja kuulutada ja siis seda iga ringiga kasutada
                int whoNext = rnd.Next(101); // TODO: kuna rnd seed on mikrosekundid, siis kiirel arvutil algab ta alati samast kohast, äkki on lihtsam ja ausam kordamööda üksteist lüüa?
                Console.WriteLine(whoNext);

                // TODO: .NET 4.6 alates lubab sul stringe elegantsemalt defineerida patterning "string interpolation", pead ainult $ string ette panema, et see töötaks:
                //  Console.WriteLine($"{firstMonster.Name} has {firstMonster.Lives} lives left. (1)"); on ju lühem ja loetavam? Seda suhkrut javas ega paljudes teistes keeltes muidugi ei ole  
                if (whoNext % 2 == 0){
                    firstMonster.Lives = firstMonster.Lives - secondMonster.HitValue; // TODO: ära elusid negatiivseks lase
                    Console.WriteLine(firstMonster.Name + " has " + firstMonster.Lives + " lives left. (1)");
                    Console.WriteLine(secondMonster.Name + " has " + secondMonster.Lives + " lives left. (1)");
                }else {
                    secondMonster.Lives = secondMonster.Lives - firstMonster.HitValue; // TODO: ära elusid negatiivseks lase
                    Console.WriteLine(secondMonster.Name + " has " + secondMonster.Lives + " lives left. (2)");
                    Console.WriteLine(firstMonster.Name + " has " + firstMonster.Lives + " lives left. (2)");
                }

                // TODO: sama asi mis enne, et tuleks kasutada IsAlive meetodit ja inversiooni ! segu
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
