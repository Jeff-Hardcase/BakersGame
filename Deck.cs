
using System.Xml;

namespace BakersGame
{
    public class Deck
    {
        public enum DeckType
        {
            Paris
        }

        public DeckType DeckName { get; set; }
        public Card[] Cards { get; set; }

        private readonly CardSuit[] cardSuits = Enum.GetValues<CardSuit>();
        private readonly CardRank[] cardRanks = Enum.GetValues<CardRank>();

        public Deck() 
        {
            Cards = SetupDeck(DeckType.Paris);
        }

        public Deck(DeckType deckType)
        {
            Cards = SetupDeck(deckType);
        }

        public bool Shuffle()
        {
            //redo with KFY shuffle algo
            int deckRandom;
            Card swapCard;
            
            var totalCards = cardSuits.Length * cardRanks.Length;
            var random = new Random(Guid.NewGuid().GetHashCode());

            for (int deckIndex = 0; deckIndex < totalCards; deckIndex++)
            {
                //swap random card with current card
                deckRandom = random.Next(totalCards - 1);
                swapCard = Cards[deckRandom];
                Cards[deckRandom] = Cards[deckIndex];
                Cards[deckIndex] = swapCard;
            }

            return true;
        }

        public bool LoadFile(string pathAndFileName)
        {
            var xpath = "div/img";
            var fileContent = File.ReadAllText(pathAndFileName);

            //massage raw data to fit xml needs, since the source is malformed
            fileContent = fileContent.Replace("touch-action: none;\"><img", "touch-action: none;\"></img><img")
                                        .Replace("draggable=\"false\"><img", "draggable=\"false\"></img><img")
                                        .Replace("</div>", "</img></div>");

            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(fileContent);

            var imgNodes = xmlDoc.SelectNodes(xpath);
            var deckIndex = 0;

            foreach (XmlNode img in imgNodes)
            {
                var cardName = img.Attributes["alt"].Value;

                if (!string.IsNullOrWhiteSpace(cardName))
                {
                    var cardData = cardName.Split(" of ");
                    var cardRankSuccess = Enum.TryParse<CardRank>(cardData.FirstOrDefault(), true, out var cardRank);
                    var cardSuitSuccess = Enum.TryParse<CardSuit>(cardData.LastOrDefault(), true, out var cardSuit);

                    if (cardRankSuccess && cardSuitSuccess)
                    {
                        Cards[deckIndex] = new Card(cardRank, cardSuit);
                        deckIndex++;
                    }
                }
            }

            return (deckIndex == cardSuits.Length * cardRanks.Length);
        }

        private Card[] SetupDeck(DeckType deckType) 
        {
            DeckName = deckType;
            var cardDeck = new Card[cardSuits.Length * cardRanks.Length];
            int cardValue;
            int cardSuit;
            int cardRank;

            foreach(var suit in cardSuits) 
            {
                foreach (var rank in cardRanks) 
                {
                    cardSuit = (int)suit;
                    cardRank = (int)rank;
                    cardValue = cardRank + (cardSuit - 1) * cardRanks.Length;

                    cardDeck[cardValue - 1] = new Card(rank, suit);
                }
            }

            return cardDeck;
        }
    }
}
