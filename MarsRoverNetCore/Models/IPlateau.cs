using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRoverNetCore.Models
{
    interface IPlateau
    {
        void AddRover(Rover rover,string commands);
        bool IsValid(Point point);
        void GetRoverPositions();
    }
}
