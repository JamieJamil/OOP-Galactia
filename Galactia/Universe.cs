using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactia
{
    #region SpaceObject
    internal abstract class SpaceObject
    {
        // Properties.
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Position PositionToString { get; set; } = new Position();

        // CLass to get X and Y.
        public class Position
        {
            public int X { get; set; }

            public int Y { get; set; }

            // ToString to convert and override "Position"
            public override string ToString()
            {
                return $"({X},{Y})";
            }
        }
    }
    #endregion
    #region StarType
    internal class StarType : SpaceObject
    {
        // Enum with named members.
        public enum Startype
        {
            YellowDwarf, White, BlueNeutron, RedGiant
        }
        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> PlanetList { get; set; } = new List<Planet>();
    }
    #endregion
    #region Planet
    internal class Planet : SpaceObject
    {
        // Enum with named members.
        public enum PlanetType
        {
            Terrestial, Giant, Dwarf, Gas_Giant
        }
        // Properties
        public PlanetType Type { get; set; }
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }
        public List<Moon> MoonList { get; set; } = new List<Moon>();

        public double Distance(StarType stars)
        {
            int x2 = stars.PositionToString.X;
            int x1 = PositionToString.X;
            int y2 = stars.PositionToString.Y;
            int y1 = PositionToString.Y;

            // Distance =√((x_2 - x_1)²+(y_2 - y_1)²)
            // Math.Sqrt Used for Square root
            // Math.Pow used to compute a number raised to the power of some other number.
            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return distance;
        }
    }
    #endregion
    #region Moon
    internal sealed class Moon : Planet
    {
        public Planet? Orbiting { get; set; }

        public double Distance(Planet planet)
        {
            int x2 = planet.PositionToString.X;
            int x1 = PositionToString.X;
            int y2 = planet.PositionToString.Y;
            int y1 = PositionToString.Y;

            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

            return distance;
        }
    }
    #endregion
}
