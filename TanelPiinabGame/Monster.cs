using System;

public class Monster {

    // TODO: see on jälle ainult soovitus, aga ilus on propertied ühele reale panna - public string Name { get; set; }
    public string Name{
        get; set;
    }

    public int Health{
        get; set;
    }

    public int HitValue{
        get; set;
    }

    // TODO: signatuur peaks olema
    //       public void Hit(Monster otherMonster)
    //       sest sa juba tead, mis koll parasjagu lööki teeb, argumendiks on vaja ainult teist kolli, keda lüüa
    public void Hit(Monster firstMonster, Monster secondMonster){
        Random rnd = new Random();
        int whoNext = rnd.Next(101); 
        // TODO: meetodi nime lugedes tuleb mõte, et üks koll lööb teist ja ei midagi rohkem
        //       sa nagu prooviks ühte Fight sammu siin läbi mängida, mis minu arvates ei ole õige
        //       realiseeri ainult selline loogika ära, et üks lööb teist, las kõrgemad struktuurid hoolitsevad selle kakluseks vormistamise eest
        if (whoNext % 2 == 0){
            firstMonster.Health = firstMonster.Health - secondMonster.HitValue; // TODO: ära elusid negatiivseks lase - dont care, my game, my rules
        }else{
            secondMonster.Health = secondMonster.Health - firstMonster.HitValue; // TODO: ära elusid negatiivseks lase
        }
        Console.WriteLine($"{firstMonster.Name}  has {firstMonster.Health} lives left and {secondMonster.Name} has {secondMonster.Health} lives left"); 
    }

    // TODO: sellel meetodil pole argument vaja, ta teab juba, kelle sees ta käima läheb
    //       proovi kirjutada lihtsalt if (Health > 0), saad praeguse kolli eludele ligi
    //       also, suur täht IsAlive on oluline convention
    public bool isAlive(Monster currentMonster){
        // TODO: nii on ka okei, aga mina teeks lihtsalt { return Health > 0; }
        if (currentMonster.Health > 0){
            return true;
        }else {
            return false;
        }
    }

    // FYI: kui sa tahad, siis .NET eelis java üle on readonly propertied, sama funktsioon kui kolli property oleks
    // public bool IsAlive { get { return Health > 0; } }

    // FYI: ning alates .NET 4.5.2 saad sa teha (aga ei pea)
    // public bool IsAlive => Health > 0; propertina
    // public bool IsAlive () => Health > 0; meetodina
}
