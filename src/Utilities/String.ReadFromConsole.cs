using System;
using System.Text;

namespace DevZest
{
    internal static partial class Extensions
    {
        public static string ReadFromConsole(this string title, bool isPassword)
        {
            Console.Write(title);
            if (!title.EndsWith(":"))
                Console.Write(':');

            if (isPassword)
                return ReadPassword();
            else
                return Console.ReadLine() ?? string.Empty;
        }

        private static string ReadPassword()
        {
            StringBuilder result = new StringBuilder();

            for (var key = Console.ReadKey(true); key.Key != ConsoleKey.Enter; key = Console.ReadKey(true))
            {
                if ((key.Modifiers & ConsoleModifiers.Control) == ConsoleModifiers.Control)
                    continue;

                if ((key.Modifiers & ConsoleModifiers.Alt) == ConsoleModifiers.Alt)
                    continue;

                if (key.Key == ConsoleKey.Backspace)
                {
                    if (result.Length > 0)
                    {
                        result.Remove(result.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                    continue;
                }

                var keyChar = key.KeyChar;
                if (char.IsControl(keyChar))
                    continue;

                result.Append(key.KeyChar);
                Console.Write("*");
            }

            Console.WriteLine();
            return result.ToString();
        }
    }
}
