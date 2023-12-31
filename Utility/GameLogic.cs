namespace SuperTikTakToe.Utility;

public class GameLogic
{
    
}

public class SubGameNode
{
    public string WinnerColor = "white";
    public bool GameFinished;
    public string[] GameBoard = Enumerable.Repeat("white", 9).ToArray();
}

