using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore
{
    static class ExceptionHelper
    {
        public static void ShowError(string message)
        {
            Console.WriteLine(message);
            throw new ArgumentException(message);
        }
    }
}
