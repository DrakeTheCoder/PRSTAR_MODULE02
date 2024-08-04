using System;
using System.Threading.Tasks;

namespace piano
{
    class Program
    {
        // Длительность в милисекундах
        private const int DURATION = 2000;

        // Частоты нот
        private const int C = 262; 
        private const int D = 294; 
        private const int E = 330; 
        private const int F = 349; 
        private const int G = 392;
        private const int A = 220;
        private const int B = 247;

        static void Main(string[] args)
        {
            Console.WriteLine("Press 'Esc' or 'Spacebar' for exit.");
            Console.WriteLine("Press 'z' C note.");
            Console.WriteLine("Press 'x' D note.");
            Console.WriteLine("Press 'c' E note.");
            Console.WriteLine("Press 'v' F note.");
            Console.WriteLine("Press 'b' G note.");
            Console.WriteLine("Press 'n' A note.");
            Console.WriteLine("Press 'm' B note.");

            bool play = true;

            while(play)
            {
                if (Console.KeyAvailable)
                {
                    switch(Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.Escape:
                        case ConsoleKey.Spacebar:
                            play = false;
                            break;
                        case ConsoleKey.Z:
                            Task.Run(() => PlayNote(C));
                            break;
                        case ConsoleKey.X:
                            Task.Run(() => PlayNote(D));
                            break;
                        case ConsoleKey.C:
                            Task.Run(() => PlayNote(E));
                            break;
                        case ConsoleKey.V:
                            Task.Run(() => PlayNote(F));
                            break;
                        case ConsoleKey.B:
                            Task.Run(() => PlayNote(G));
                            break;
                        case ConsoleKey.N:
                            Task.Run(() => PlayNote(A));
                            break;
                        case ConsoleKey.M:
                            Task.Run(() => PlayNote(B));
                            break;
                    }
                }
            }
        }

        static void PlayNote(int note)
        {
            Console.Beep(note, DURATION);
        }
    }
}
