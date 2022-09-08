namespace Galactia
{
    // Planet class that inheritates.
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
        public List<Moon> MoonList { get; set; }

        public double Distance()
        {
            int x2 = star.ObjectPositions.X;
            int x1 = ObjectPositions.X;
            int y2 = star.ObjectPositions.Y;
            int y1 = ObjectPositions.Y;
            // Distance =√((x_2 - x_1)²+(y_2 - y_1)²)
            // Math.Sqrt Used for Square root
            // Math.Pow used to compute a number raised to the power of some other number.
            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + (Math.Pow(y1 - y2, 2)));

            return distance;
        }
    }
}