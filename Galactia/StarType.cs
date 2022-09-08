namespace Galactia
{
    internal class StarType
    {
        // Enum with named members
        public enum Startype
        {
            YellowDwarf, White, BlueNeutron, RedGiant
        }
        // Star class inherits from SpaceObject
        internal class Star : SpaceObject
        {
            public Startype Type { get; set; }
            public int Temperature { get; set; }
            public List<Planet>? PlanetList { get; set; }
            // Position from 
            public override Position PositionToString { get; set; } = new Position() { X = 0, Y = 0 };

        }
    }
}
