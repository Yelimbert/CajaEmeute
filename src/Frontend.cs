using System;

namespace CajaEmeute
{
    class Frontend
    {
        public static void StartupScreen()
        {
            Console.WriteLine("-------====|CAJA EMEUTE|====-------");
            Console.Write("\n\n");
        }

        public static void Menu()
        {
            //Display options
            Console.WriteLine("-------Presione un numero-------");
            Console.WriteLine("1.Debug");
            Console.WriteLine("2.New Transaction");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    DebugSubmenu();
                    break;
                case '2':
                    Program.mainSession.CreateTransaction(new Transaction(Console.ReadLine(), "test", 404));
                    break;
                default:
                    break;
            }
        }

        public static void DebugSubmenu()
        {
            Console.WriteLine("----------Debug Menu----------");
            Console.WriteLine("1.Print Buffer");
            Console.WriteLine("2.Deque Last On Buffer");

            switch (Console.ReadKey().KeyChar)
            {
                case '1':
                    Console.WriteLine(Program.mainSession.debugOut());
                    break;
                case '2':
                    Program.mainSession.BufferCleanup();
                    break;
                default:
                    break;
            }
        }
    }
}