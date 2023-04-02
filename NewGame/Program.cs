namespace NewGame
{
    class Game
    {
        static void Main(string[] args)
        {
            StartMenu menu = new StartMenu();
            menu.PrintStartMenu();
            GameProcess gameProcess = new GameProcess();
            gameProcess.GProcess();
        }
    }
}