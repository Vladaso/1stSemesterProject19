using System;

namespace WorldOfZuul
{
    public static class ConsoleUtils
    {
        public static void ClearConsole()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("\x1b[3J");
                Console.Clear();
            }
            catch (System.IO.IOException)
            {
            }
        }
    }
}