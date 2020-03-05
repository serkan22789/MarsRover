using MarsRoverNetCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using static MarsRoverNetCore.Models.Point;

namespace MarsRoverNetCore
{
    public class Rover : IRover
    {
        public Rover(Point aPoint)
        {
            point = aPoint;
        }
        Point point { get; set; }

        public void Move()
        {
            point.Move();
        }
        public Point GetPoint()
        {
            return point;
        }
        public void SetPoint(Point aPoint)
        {
            point = aPoint;
        }
        public void TurnLeft()
        {
            point.Direction = (point.Direction - 1) < Directions.N ? Directions.W : point.Direction - 1;
        }
        public void TurnRight()
        {
            point.Direction = (point.Direction + 1) > Directions.W ? Directions.N : point.Direction + 1;
        }
        public override string ToString()
        {
            return string.Format("{0} {1} {2}", point.X, point.Y, point.Direction);
        }
    }
}
