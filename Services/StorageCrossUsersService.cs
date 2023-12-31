namespace SuperTikTakToe.Services;

public class StorageCrossUsersService
{
    public string[,] SubGameColor { get; set; } = new string[9,9];
    public string[] MainGameColor { get; set; } = Enumerable.Repeat("white", 9).ToArray();
    public bool[] FinishedBoards { get; set; } = Enumerable.Repeat(false, 9).ToArray();
    public int? ActiveBoard = null;
    public bool IsPlayerRed { get; set; } = true;
    public bool GameFinished { get; set; }
    public string WinnerColor { get; set; } = null!;

    public StorageCrossUsersService()
    {
        for (var j = 0; j < 9; j++)
        {
            for (var i = 0; i < 9; i++)
            {
                SubGameColor[j, i] = "white";
            }
        }
    }

    public string GetCurrentPlayerColor()
    {
        return IsPlayerRed ? "red" : "blue";
    }
}