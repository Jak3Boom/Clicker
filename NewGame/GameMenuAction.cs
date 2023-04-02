namespace NewGame
{
    public class GameMenuAction
    {
        public void GMenuAction(GameElements elements, ref string selectMainAction)
        {
            GameMenu gameMenu = new GameMenu();

            do
            {
                gameMenu.PrintGameMenu(elements);

                selectMainAction = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(new string('-', Console.WindowWidth));
                Console.ForegroundColor = ConsoleColor.DarkYellow;

            } while (string.IsNullOrWhiteSpace(selectMainAction) || selectMainAction != "1" && selectMainAction != "2");
        }
    }
}
