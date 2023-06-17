namespace Memento;

public class PlayerStateMemento
{
    public int Hp { get; set;}
    public int Mp { get; set;}

    public PlayerStateMemento(int hp, int mp)
    {
        Hp = hp;
        Mp = mp;
    }
}