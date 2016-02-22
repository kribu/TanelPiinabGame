using System;

public class Monster {

    public string Name{get; set;}

    public int Health{get; set;}

    public int HitValue{get; set;}

    public bool IsAlive(Monster currentMonster) { return Health > 0; }

    public void Hit(Monster otherMonster){
        otherMonster.Health = otherMonster.Health - HitValue;
        Console.WriteLine($"{otherMonster.Name} has {otherMonster.Health} lives left");
    }

    // FYI: kui sa tahad, siis .NET eelis java üle on readonly propertied, sama  funktsioon kui kolli property oleks
    // public bool IsAlive { get { return Health > 0; } }
    // FYI: ning alates .NET 4.5.2 saad sa teha (aga ei pea)
    // public bool IsAlive => Health > 0; propertina
    // public bool IsAlive () => Health > 0; meetodina
    // not yet
}