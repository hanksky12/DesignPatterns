namespace Memento;

public class GamePlayer
{
    public int Hp { get; private set;}
    public int Mp { get; set;}
    public int Attack { get; set;}
    public int Defense { get; set;}

    public void ShowState()
    {
        Console.WriteLine("[Player state]:");
        Console.WriteLine($"Hp {Hp}");
        Console.WriteLine($"Mp {Mp}");
        Console.WriteLine($"Attack {Attack}");
        Console.WriteLine($"Defense {Defense}");
    }

    public void InitState()
    {
        Hp = 100;
        Mp = 100;
        Attack = 100;
        Defense = 100;
    }

    public void Fight(int hpDamage, int mpDamage, int attack, int defense)
    {
        Console.WriteLine("Start Fight~~~~~~");
        Hp -= hpDamage;
        Mp -= mpDamage;
        Attack -= attack;
        Defense -= defense;
    }

    public PlayerStateMemento RecordState()
    {
        return (new PlayerStateMemento(Hp, Mp));
    }

    public void BachInTimeState(PlayerStateMemento memento)
    {
        Console.WriteLine("Restore~~~~~~~State");
        Hp = memento.Hp;
        Mp = memento.Mp;
    }
}

