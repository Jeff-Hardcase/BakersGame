
namespace BakersGame
{
    public class BakersGameTable
    {
        public enum BakersGameLocation
        {
            Column,
            Reserve,
            Foundation
        }

        public BakersGameLocation Location { get; set; }
        public int LocationIndex { get; set; }
    }
}
