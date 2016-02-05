using System;

public class Monster{

    public string Name{
        get; set;
    }

    public int Health{
        get; set;
    }

    public int HitValue{
        get; set;
    }

    public void Hit(Monster firstMonster, Monster secondMonster){
        Random rnd = new Random();
        int whoNext = rnd.Next(101); 
        if (whoNext % 2 == 0){
            firstMonster.Health = firstMonster.Health - secondMonster.HitValue; // TODO: ära elusid negatiivseks lase - dont care, my game, my rules
        }else{
            secondMonster.Health = secondMonster.Health - firstMonster.HitValue; // TODO: ära elusid negatiivseks lase
        }
        Console.WriteLine($"{firstMonster.Name}  has {firstMonster.Health} lives left and {secondMonster.Name} has {secondMonster.Health} lives left"); 
    }

    public bool isAlive(Monster currentMonster){
        if (currentMonster.Health > 0){
            return true;
        }else {
            return false;
        }
    }
}
