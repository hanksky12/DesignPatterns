namespace Memento;

public class PlayerStateMemento
{
    public int Hp { get; private set;}
    public int Mp { get; private set;}

    public PlayerStateMemento(int hp, int mp)
    {
        Hp = hp;
        Mp = mp;
    }
}