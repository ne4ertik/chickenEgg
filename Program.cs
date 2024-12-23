namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread chickenThread = new Thread(PrintChicken);
            Thread eggThread = new Thread(PrintEgg);
            Console.WriteLine("Спор начался! Участники спора: ");
            chickenThread.Start();
            eggThread.Start();


            chickenThread.Join();
            eggThread.Join();


            if (eggThread.IsAlive)
            {
                Console.WriteLine("Побеждает: Яйцо");
            }
            else
            {
                Console.WriteLine("Побеждает: Курица");
            }
        }
        static void PrintEgg()
        {
            Console.WriteLine("Яйцо");
        }
        static void PrintChicken()
        {
            Console.WriteLine("Курица");
        }
    }
    }

