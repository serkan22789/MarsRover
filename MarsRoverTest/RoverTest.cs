using MarsRoverNetCore;
using MarsRoverNetCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTest
{
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void FirstRoverCheckOutput()
        {
            Plateau Plateau = new Plateau(5, 5);
            Rover rover = new Rover(new Point(1, 2, "N"));
            Plateau.AddRover(rover, "LMLMLMLMM");
            Assert.AreEqual(rover.ToString(), "1 3 N");
        }

        [TestMethod]
        public void SecondRoverCheckOutput()
        {
            Plateau Plateau = new Plateau(5, 5);
            Rover rover = new Rover(new Point(3, 3, "E"));
            Plateau.AddRover(rover, "MMRMMRMRRM");
            Assert.AreEqual(rover.ToString(), "5 1 E");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void IncorrectCommand()
        {
            Plateau Plateau = new Plateau(5, 5);
            Rover rover = new Rover(new Point(3, 3, "E"));
            Plateau.AddRover(rover, "AMMRMMRMRRM");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void IncorrectDirection()
        {
            Plateau Plateau = new Plateau(5, 5);
            Rover rover = new Rover(new Point(3, 3, "K"));
            Plateau.AddRover(rover, "MMRMMRMRRM");
        }

        [TestMethod]
        public void CheckBorderCrossing()
        {
            Plateau Plateau = new Plateau(2, 2);
            Rover rover = new Rover(new Point(0, 0, "W"));
            Plateau.AddRover(rover, "MMM");
            Assert.AreEqual(rover.ToString(), "0 0 W");
        }
    }
}
