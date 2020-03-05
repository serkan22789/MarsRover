using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore.Models
{
    public class Point //struct
    {
        public int X;
        public int Y;
        public Directions Direction;

        public Point(int aX, int aY, string aDirection)
        {
            X = aX;
            Y = aY;
            SetDirection(aDirection);

        }

        private void SetDirection(string aDirection)
        {
            try
            {
                Direction = (Directions)Enum.Parse(typeof(Directions), aDirection);
            }
            catch (Exception)
            {
                ExceptionHelper.ShowError(string.Format("Invalid Direction: {0}", aDirection));
            }
        }

        public void Move()
        {
            switch (Direction)
            {
                case Directions.N:
                    Y++;
                    break;
                case Directions.S:
                    Y--;
                    break;
                case Directions.W:
                    X--;
                    break;
                case Directions.E:
                    X++;
                    break;
            }
        }

        public enum Directions
        {
            N = 1,
            E = 2,
            S = 3,
            W = 4
        }
    }
}
