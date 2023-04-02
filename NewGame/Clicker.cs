namespace NewGame
{
    public class Clicker
    {
        GameElements elements = new GameElements();
        public void Clicks(GameElements elements)
        {
            Console.WriteLine("Нажимайте на <Spacebar>, чтобы заработать очки. Для выхода в меню, нажмите <Escape>");

            // Кликер
            Console.Write($"\nБаланс: ");
            float balance = elements.Balance;
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    balance += elements.factor;
                    Console.SetCursorPosition(8, Console.CursorTop);
                    Console.Write(new string(' ', Console.BufferWidth - 8));
                    Console.SetCursorPosition(8, Console.CursorTop);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{balance} очков");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
            } while (keyInfo.Key != ConsoleKey.Escape);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('-', Console.WindowWidth));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            elements.Balance = balance;
        }
    }
}
