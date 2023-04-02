namespace NewGame
{
    public class GameProcess
    {
        public void GProcess()
        {
            GameMenu gameMenu = new GameMenu();
            Shop shopPanel = new Shop();
            Clicker clicker = new Clicker();
            GameElements elements = new GameElements();


            GameMenuAction gMenuAction = new GameMenuAction();
            string selectMainAction = "";
            while (true)
            {
                gMenuAction.GMenuAction(elements, ref selectMainAction);

                switch (selectMainAction)
                {
                    // Вызов магазина
                    case "1":
                        ConsoleKeyInfo keyInfo;
                        do
                        {
                            // Вывод панели магазина
                            shopPanel.PrintShopPanel(elements);

                            // Выбор одного из действий в магазине
                            keyInfo = Console.ReadKey(true);

                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine(new string('-', Console.WindowWidth));
                            Console.ForegroundColor = ConsoleColor.DarkYellow;

                        } while (keyInfo.Key != ConsoleKey.D1 && keyInfo.Key != ConsoleKey.D2 && keyInfo.Key != ConsoleKey.D3 && keyInfo.Key != ConsoleKey.Escape);

                        switch (keyInfo.Key)
                        {
                            // Если выбрал 1 (Усиление 1.5x)
                            case ConsoleKey.D1:

                                // Если баланс меньше 100
                                if (elements.Balance < 100)
                                {
                                    do
                                    {
                                        // Уведомление о недостаточном количестве очков
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Недостаточно очков для покупки.\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                                        // Вывод меню магазина
                                        shopPanel.PrintShopPanel(elements);
                                        Console.WriteLine();

                                        // Выбор элемента магазина
                                        keyInfo = Console.ReadKey(true);
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine(new string('-', Console.WindowWidth));
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                                    } while (elements.Balance < 100 && keyInfo.Key != ConsoleKey.Escape);
                                }
                                else if (elements.IsUpgrade1Bought)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Это улучшение уже было куплено"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Вы приобрели ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\"Усиление ");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("1.5x");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("\"\n");
                                    elements.Balance -= 100;
                                    elements.factor = 1.5f;
                                    elements.IsUpgrade1Bought = true;
                                }
                                break;
                            case ConsoleKey.D2:

                                // Если баланс меньше 20
                                if (elements.Balance < 200)
                                {
                                    do
                                    {
                                        // Уведомление о недостаточном количестве очков
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Недостаточно очков для покупки.\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                                        // Вывод меню магазина
                                        shopPanel.PrintShopPanel(elements);
                                        Console.WriteLine();

                                        // Выбор элемента магазина
                                        keyInfo = Console.ReadKey(true);
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine(new string('-', Console.WindowWidth));
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                                    } while (elements.Balance < 200 && keyInfo.Key != ConsoleKey.Escape);
                                }
                                else if (elements.IsUpgrade2Bought)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Это улучшение уже было куплено"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Вы приобрели ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\"Усиление ");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("1.75x");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("\"\n");
                                    elements.Balance -= 200;
                                    elements.factor = 1.75f;
                                    elements.IsUpgrade2Bought = true;
                                }
                                break;
                            case ConsoleKey.D3:

                                // Если баланс меньше 300
                                if (elements.Balance < 300)
                                {
                                    do
                                    {
                                        // Уведомление о недостаточном количестве очков
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("Недостаточно очков для покупки.\n");
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                                        // Вывод меню магазина
                                        shopPanel.PrintShopPanel(elements);
                                        Console.WriteLine();

                                        // Выбор элемента магазина
                                        keyInfo = Console.ReadKey(true);
                                        Console.ForegroundColor = ConsoleColor.DarkGray;
                                        Console.WriteLine(new string('-', Console.WindowWidth));
                                        Console.ForegroundColor = ConsoleColor.DarkYellow;

                                    } while (elements.Balance < 300 && keyInfo.Key != ConsoleKey.Escape);
                                }
                                else if (elements.IsUpgrade3Bought)
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkRed; Console.WriteLine("Это улучшение уже было куплено"); Console.ForegroundColor = ConsoleColor.DarkYellow;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Green; Console.Write("Вы приобрели ");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.Write("\"Усиление ");
                                    Console.ForegroundColor = ConsoleColor.DarkCyan; Console.Write("2x");
                                    Console.ForegroundColor = ConsoleColor.DarkYellow; Console.WriteLine("\"\n");
                                    elements.Balance -= 300;
                                    elements.factor = 2f;
                                    elements.IsUpgrade3Bought = true;
                                }
                                break;
                            case ConsoleKey.Escape:
                                // Выход в меню
                                shopPanel.PrintShopPanel(elements);
                                Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(new string('-', Console.WindowWidth)); Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                        }
                        break;

                    // Начало игры
                    case "2":
                        clicker.Clicks(elements);
                        break;
                }
            }
        }
    }
}
