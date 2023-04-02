namespace NewGame
{
    public class GameMenu
    {
        public void PrintGameMenu(GameElements elements)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            // Текущий баланс
            Console.Write("Текущий баланс: "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"{elements.Balance} очков"); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nВыберите действие:\n");

            // Магазин
            Console.WriteLine("1. Магазин");

            // Кликер
            Console.WriteLine("2. Кликер\n");
        }
    }
}
