namespace Galactia
{
    // Star class inherits from SpaceObject.
    internal class StarType : SpaceObject
    {
        // Enum with named members.

        public enum Startype
        {
            YellowDwarf, White, BlueNeutron, RedGiant
        }
        public Startype Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> PlanetList { get; set; }
    }
}
