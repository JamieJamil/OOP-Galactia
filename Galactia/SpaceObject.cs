namespace Galactia
{
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
}
