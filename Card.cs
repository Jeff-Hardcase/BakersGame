
namespace BakersGame
{
    public enum CardSuit
    {
        Clubs = 1,
        Diamonds,
        Hearts,
        Spades
    }

    public enum CardRank
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class Card
    {
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }
        private readonly int MaxRank = (int)Enum.GetValues<CardRank>().Max();
        public readonly int Value;
        public BakersGameTable BakersGame { get; set; }
        public PictureBox CardPicture {  get; set; }
        public string CardName => GetCardName();
        public string LongName => GetLongName();

        public Card(CardRank rank, CardSuit suit)
        {
            Rank = rank;
            Suit = suit;
            Value = (int)rank + MaxRank * ((int)suit - 1);
            BakersGame = new BakersGameTable();
        }

        public Card(int cardValue)
        {
            Value = cardValue;
            Suit = (CardSuit)((cardValue - 1) / 13 + 1);
            Rank = (CardRank)((cardValue - 1) % 13 + 1);
            BakersGame = new BakersGameTable();
        }

        private string GetCardName()
        {
            var cardLevel = $"{Rank}".ToLower() switch
            {
                "ace" => "A",
                "two" => "2",
                "three" => "3",
                "four" => "4",
                "five" => "5",
                "six" => "6",
                "seven" => "7",
                "eight" => "8",
                "nine" => "9",
                "ten" => "10",
                "jack" => "J",
                "queen" => "Q",
                "king" => "K",
                _ => string.Empty,
            };

            var cardSuit = $"{Suit}"[0..1].ToLower();

            return $"{cardLevel}{cardSuit}";
        }

        private string GetLongName()
        {
            return $"{Rank} of {Suit}";
        }
    }
}
