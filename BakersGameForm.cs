
namespace BakersGame
{
    public partial class BakersGameForm : Form
    {
        private Deck theDeck = new();
        private Card[] Reserve;
        private List<Card>[] Foundation;
        private List<Card>[] Columns;
        private bool isDragging;
        private int oldX, oldY;
        private Point cardStartLocation;

        private readonly string cardControlNamePrefix = "cardBox";
        private readonly string cardDeck = "Anglo";

        //initial values
        private readonly int theTop = 320;
        private readonly int theLeft = 120;
        private readonly int theWidth = 176;
        private readonly int theHeight = 274;
        private readonly int theWidthOffset = 25;
        private readonly int theHeightOffset = 60;

        public BakersGameForm()
        {
            InitializeComponent();
        }

        private void btnNewDeal_Click(object sender, EventArgs e)
        {
            theDeck.Shuffle();

            PlayGame();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            //create a hand to play from a file
            var sourceFolder = "D:\\Jeff\\code\\Data";
            var sourceFile = "RawDeckData.xml.mangled.txt";

            var fileName = Path.Combine(sourceFolder, sourceFile);

            var success = theDeck.LoadFile(fileName);

            if (success)
                PlayGame();
            else
                MessageBox.Show("File load failed. Check to see if the file is accurate.");
        }

        private void picCard_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBox = sender as PictureBox;
            pictureBox.BringToFront();

            if (e.Button == MouseButtons.Right)
            {
                var theDeckIndex = Convert.ToInt32(pictureBox.Name[cardControlNamePrefix.Length..]);
                Card thisCard = theDeck.Cards[theDeckIndex];
                int intX = 0;
                string strPanelName = "panelHome";
                var endLoop = false;
                Card topCard;

                do
                {
                    var theCardColumn = Foundation[intX];

                    topCard = theCardColumn.LastOrDefault();

                    if ((topCard is null && thisCard.Rank == CardRank.Ace)
                        || (topCard is not null && topCard.Suit == thisCard.Suit && topCard.Rank + 1 == thisCard.Rank))
                    {
                        //pull card
                        RemoveCard(thisCard);
                        //tag where it will be located
                        thisCard.BakersGame.Location = BakersGameTable.BakersGameLocation.Foundation;
                        thisCard.BakersGame.LocationIndex = intX;
                        //put it at new location
                        theCardColumn.Add(thisCard);
                        strPanelName += $"{intX}";

                        endLoop = true;
                        break;
                    }

                    intX += 1;
                }
                while (!(endLoop || intX > 3));

                if (endLoop)
                {
                    var thePanel = this.Controls.Find(strPanelName, false).First() as Panel;

                    pictureBox.Location = thePanel.Location;
                }
            }
            else
            {
                isDragging = true;
                oldX = e.X;
                oldY = e.Y;
                cardStartLocation = pictureBox.Location;
            }
        }

        private void picCard_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int intX;
                Panel myPanel;
                Card topCard;
                var cardPlayed = false;
                var thisPic = sender as PictureBox;

                var thisIndex = Convert.ToInt32(thisPic.Name.Remove(0, cardControlNamePrefix.Length));
                var thisCard = theDeck.Cards[thisIndex];

                // //trying to put it in reserve?
                for (intX = 0; intX <= 3; intX++)
                {
                    topCard = Reserve[intX];

                    if (topCard is null)
                    {
                        myPanel = this.Controls.Find($"panelReserve{intX}", false).First() as Panel;

                        if (myPanel.Bounds.IntersectsWith(thisPic.Bounds))
                        {
                            // //pull it out
                            RemoveCard(thisCard);
                            //tag where it will be located
                            thisCard.BakersGame.Location = BakersGameTable.BakersGameLocation.Reserve;
                            thisCard.BakersGame.LocationIndex = intX;
                            // //now put it in
                            Reserve[intX] = thisCard;

                            thisPic.Location = myPanel.Location;

                            cardPlayed = true;
                            break;
                        }
                    }
                }

                if (!cardPlayed)
                {
                    // //maybe one of the columns?
                    for (intX = 0; intX <= 7; intX++)
                    {
                        int ColumnLength = Columns[intX].Count;

                        if (ColumnLength == 0)
                        {
                            // //does the user want it here?
                            var myRect = new Rectangle(theLeft + intX * theWidth + intX * theWidthOffset, theTop, theWidth, theHeight);

                            if (myRect.IntersectsWith(thisPic.Bounds))
                            {
                                // //yep, so pull it from current, then put it in new
                                RemoveCard(thisCard);
                                //tag where it will be located
                                thisCard.BakersGame.Location = BakersGameTable.BakersGameLocation.Column;
                                thisCard.BakersGame.LocationIndex = intX;
                                //now put it in
                                Columns[intX].Add(thisCard);

                                thisPic.Location = myRect.Location;

                                cardPlayed = true;
                                break;
                            }
                        }
                        else
                        {
                            topCard = Columns[intX][ColumnLength - 1];

                            if (thisCard.Suit == topCard.Suit & thisCard.Rank + 1 == topCard.Rank)
                            {
                                // //pull it
                                RemoveCard(thisCard);
                                //tag where it will be located
                                thisCard.BakersGame.Location = BakersGameTable.BakersGameLocation.Column;
                                thisCard.BakersGame.LocationIndex = intX;
                                // //add to this column
                                Columns[intX].Add(thisCard);

                                thisPic.Left = theLeft + intX * theWidth + intX * theWidthOffset;
                                thisPic.Top = theTop + ColumnLength * theHeightOffset;

                                cardPlayed = true;
                                break;
                            }
                        }
                    }
                }

                if (!cardPlayed)
                {
                    //put it back to start
                    thisPic.Location = cardStartLocation;
                }

            }

            isDragging = false;
        }

        private void picCard_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                var thisPicture = sender as PictureBox;

                if (thisPicture != null)
                {
                    thisPicture.Top += e.Y - oldY;
                    thisPicture.Left += e.X - oldX;
                }
            }
        }

        private void PlayGame()
        {
            var totalColumns = 8;
            var totalCards = theDeck.Cards.Length;

            Foundation = new List<Card>[4].Select(_ => new List<Card>()).ToArray();
            Columns = new List<Card>[totalColumns].Select(_ => new List<Card>()).ToArray();
            Reserve = new Card[4];

            //clear any existing
            for (var card = 0; card < totalCards; card++)
            {
                this.Controls.RemoveByKey($"{cardControlNamePrefix}{card}");
            }

            //walk it twice because it looks better to clear first
            for (var cardIndex = 0; cardIndex < totalCards; cardIndex++)
            {
                var theRow = cardIndex / totalColumns;
                var theColumn = cardIndex % totalColumns;
                var theCard = theDeck.Cards[cardIndex];

                var pictureBox = new PictureBox()
                {
                    Name = $"{cardControlNamePrefix}{cardIndex}",
                    Location = new Point(theLeft + (theWidth + theWidthOffset) * theColumn, theTop + theHeightOffset * theRow),
                    Size = new Size(theWidth, theHeight),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    //Image = (Image)Properties.Resources.ResourceManager.GetObject(theCard.CardName)
                    Image = Image.FromFile($"Images/Decks/{cardDeck}/{theCard.CardName}.png")
                };

                pictureBox.MouseDown += new MouseEventHandler(picCard_MouseDown);
                pictureBox.MouseUp += new MouseEventHandler(picCard_MouseUp);
                pictureBox.MouseMove += new MouseEventHandler(picCard_MouseMove);

                this.Controls.Add(pictureBox);

                theCard.BakersGame.Location = BakersGameTable.BakersGameLocation.Column;
                theCard.BakersGame.LocationIndex = theColumn;

                Columns[theColumn].Add(theCard);

                pictureBox.BringToFront();
            }

        }

        private void RemoveCard(Card card)
        {
            var location = card.BakersGame.Location;
            var index = card.BakersGame.LocationIndex;

            //Foundation handled by right-click in mouse down
            if (location == BakersGameTable.BakersGameLocation.Column)
            {
                Columns[index].Remove(card);
            }

            if (location == BakersGameTable.BakersGameLocation.Reserve)
            {
                Reserve[index] = null;
            }
        }
    }
}