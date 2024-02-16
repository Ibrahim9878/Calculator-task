using System.Collections.Specialized;
using System.Transactions;

Console.WriteLine("a");
int choose = 1;
do
{
begin:
    Console.Clear();
    switch (choose)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--> Go Calculator ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Exit");
            break;
        case 2:
            Console.WriteLine("Go Calculator ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--> Exit");
            Console.ForegroundColor = ConsoleColor.White;
            break;
        default:
            break;
    }


    ConsoleKeyInfo info = Console.ReadKey();
    switch (info.Key)
    {
        case ConsoleKey.UpArrow:
            switch (choose)
            {
                case 1:
                    choose = 2;
                    break;
                default:
                    choose--;
                    break;
            }
            break;
        case ConsoleKey.DownArrow:
            switch (choose)
            {
                case 2:
                    choose = 1;
                    break;
                default:
                    choose++;
                    break;
            }
            break;
        case ConsoleKey.Enter:
            switch (choose)
            {
                case 1:
                    Console.Write("Enter Num1: ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Num2: ");
                    int num2 = int.Parse(Console.ReadLine());

                    int select = 1;
                    Console.WriteLine("Choose one of theese things: ");
                    do
                    {
                        Console.Clear();
                        switch (select)
                        {
                            case 1:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  -->  +");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("       -");
                                Console.WriteLine("       *");
                                Console.WriteLine("       /");
                                Console.WriteLine("       %");
                                break;
                            case 2:
                                Console.WriteLine("       +");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  -->  -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("       *");
                                Console.WriteLine("       /");
                                Console.WriteLine("       %");
                                break;
                            case 3:
                                Console.WriteLine("       +");
                                Console.WriteLine("       -");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  -->  *");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("       /");
                                Console.WriteLine("       %");
                                break;
                            case 4:
                                Console.WriteLine("       +");
                                Console.WriteLine("       -");
                                Console.WriteLine("       *");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  -->  /");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("       %");
                                break;
                            case 5:
                                Console.WriteLine("       +");
                                Console.WriteLine("       -");
                                Console.WriteLine("       *");
                                Console.WriteLine("       /");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("  -->  %");
                                Console.ForegroundColor = ConsoleColor.White;
                                break;
                            default:
                                break;


                        }

                        ConsoleKeyInfo info2 = Console.ReadKey();
                        switch (info2.Key)
                        {
                            case ConsoleKey.UpArrow:
                                switch (select)
                                {
                                    case 1:
                                        select = 5;
                                        break;
                                    default:
                                        select--;
                                        break;
                                }
                                break;
                            case ConsoleKey.DownArrow:
                                switch (select)
                                {
                                    case 5:
                                        select = 1;
                                        break;
                                    default:
                                        select++;
                                        break;
                                }
                                break;
                            case ConsoleKey.Enter:
                                Console.Clear();
                                switch (select)
                                {
                                    case 1:
                                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        Console.WriteLine($"{num1} % {num2} = {num1 % num2}");
                                        Console.ReadKey();
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                goto begin;

                        }

                    } while (true);

                case 2:
                    Console.Clear();
                    Console.WriteLine("You succesfully exited");
                    System.Environment.Exit(0);
                    break;
            }
            break;
        default:
            break;
    }
} while (true);
