using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore.Models
{
    interface IRover
    {
        void Move();
        Point GetPoint();
        void SetPoint(Point point);
        void TurnLeft();
        void TurnRight();

    }
}
