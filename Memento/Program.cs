using Memento;
static void Main()
{
    GamePlayer LolEkko = new GamePlayer();
    LolEkko.InitState();
    LolEkko.ShowState();
    PlayerStateCaretaker playerStateCaretaker = new PlayerStateCaretaker();
    playerStateCaretaker.memento = LolEkko.RecordState();
    LolEkko.Fight(50,60,20,10);
    LolEkko.ShowState();
    LolEkko.BachInTimeState(playerStateCaretaker.memento);
    LolEkko.ShowState();

}
Main();