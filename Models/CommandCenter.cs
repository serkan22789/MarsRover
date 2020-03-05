using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore.Models
{
    public class CommandCenter
    {
        public void Execute()
        {
            var size = Console.ReadLine().Split(' ');
            Plateau Plateau = new Plateau(Convert.ToInt32(size[0]), Convert.ToInt32(size[1]));
            for (int x = 0; x < 2; x++)
            {
                var roverInfo = Console.ReadLine().Split(' ');
                Rover rover = new Rover(new Point(Convert.ToInt32(roverInfo[0]), Convert.ToInt32(roverInfo[1]), roverInfo[2]));
                var command = Console.ReadLine().Trim();
                Plateau.AddRover(rover, command);
            }
            Plateau.GetRoverPositions();
        }
    }
}
