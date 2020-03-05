using MarsRoverNetCore.Models;
using System;

namespace MarsRoverNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            CommandCenter commandCenter = new CommandCenter();
            commandCenter.Execute();
            
        }
    }
}
