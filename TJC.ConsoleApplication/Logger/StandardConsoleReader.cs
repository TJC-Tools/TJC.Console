﻿namespace TJC.ConsoleApplication.Logger
{
    internal class StandardConsoleReader : IConsoleReader
    {
        public ConsoleKeyInfo ReadKey() =>
            Console.ReadKey();

        public string? ReadLine() =>
            Console.ReadLine();

        public int Read() =>
            Console.Read();
    }
}