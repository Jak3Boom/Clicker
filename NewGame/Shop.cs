namespace NewGame
{
    public class Shop
    {
        public void PrintShopPanel(GameElements elements)
        {
            Console.Write("Текущий баланс: "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine($"{elements.Balance} очков"); Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine("Список усилений:");
            Console.WriteLine();

            // Усиление 1.5x
            Console.Write("1. Усиление "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("1.5x "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("| Цена: "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("100 очков"); Console.ForegroundColor = ConsoleColor.DarkYellow;

            // Усиление 1.75x
            Console.Write("2. Усиление "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("1.75x "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("| Цена: "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("200 очков"); Console.ForegroundColor = ConsoleColor.DarkYellow;

            // Усиление 2x
            Console.Write("3. Усиление "); Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("2x "); Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("| Цена: "); Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("300 очков"); Console.ForegroundColor = ConsoleColor.DarkYellow;

            // Для выхода нажать <Escape>
            Console.WriteLine("\nДля выхода в меню, нажмите <Escape>");
        }
    }
}
