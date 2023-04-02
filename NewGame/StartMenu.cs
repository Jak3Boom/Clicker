namespace NewGame
{
    public class StartMenu
    {
        public void PrintStartMenu()
        {
            GameElements elements = new GameElements();

            // Приветствие
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string greetingText = "Приветствую!";
            Console.SetCursorPosition(Console.WindowWidth / 2 - greetingText.Length, 0);
            Console.WriteLine($"{greetingText}");
            Console.WriteLine("\n\n");

            // Ввод псевдонима игрока
            elements.nickname = "";
            do
            {
                Console.Write("Введите имя: ");
                elements.nickname = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(elements.nickname));
            Console.WriteLine();

            // Основная информация
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"{elements.nickname}, ваш баланс на {DateTime.Now} - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{elements.Balance} очков");

            // Начать игру
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nНажмите <Enter>, чтобы начать игру...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(new string('-', Console.WindowWidth));
        }
    }
}
