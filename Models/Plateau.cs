using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore.Models
{
    public class Plateau : IPlateau
    {
        public Plateau(int x, int y)
        {
            size = new Size { Width = x, Height = y };
        }
        private Size size { get; set; }
        private List<Rover> rovers = new List<Rover>();

        public bool IsValid(Point aPoint)
        {
            var isValidX = aPoint.X >= 0 && aPoint.X <= size.Width;
            var isValidY = aPoint.Y >= 0 && aPoint.Y <= size.Height;
            return isValidX && isValidY;
        }
        public void AddRover(Rover rover, string commands)
        {
            for (int i = 0; (i < commands.Length); i++ )
            {
                switch (commands[i])
                {
                    case 'L':
                        rover.TurnLeft();
                        break;
                    case 'R':
                        rover.TurnRight();
                        break;
                    case 'M':
                        Point newPoint = rover.GetPoint();
                        newPoint.Move();
                        if (IsValid(newPoint))
                        {
                            rover.SetPoint(newPoint);
                        }
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid value: {0}", commands[i]));
                }
            }
            rovers.Add(rover);
        }
        public void GetRoverPositions()
        {
            foreach (Rover item in rovers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
