using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run Program ---------------------------------------------------//
            DeckTesting.Test();

            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }
    }


    //Deck's Functions Testing Class ----------------------------------------//
    static class DeckTesting
    {
        //Testing Deck Class and Methods ------------------------------------//
        public static void Test()
        {
            //Create Deck and Print it --------------------------------------//
            Deck myDeck = new Deck();
            
            Console.WriteLine("Deck cards name:");    //Show name
            Deck.ShowDeck(myDeck, "name");
            
            Console.WriteLine("\nDeck cards ID:");    //Show ID
            Deck.ShowDeck(myDeck, "id");
            
            Console.WriteLine("\nDeck cards value:"); //Show value
            Deck.ShowDeck(myDeck, "value");


            //Shuffles Deck -------------------------------------------------//
            Deck.Shuffle(myDeck);

            Console.WriteLine("\n\nShuffle Deck:");
            myDeck.ShowDeck("name");


            //Sort Deck -----------------------------------------------------//
            myDeck.SortDeck("name");  //Sort by value

            Console.WriteLine("\nSort Deck by name:");
            myDeck.ShowDeck("name");

            myDeck.SortDeck("value"); //Sort by value

            Console.WriteLine("\nSort Deck by value:");
            myDeck.ShowDeck("value");

            myDeck.SortDeck("id");    //Sort by ID

            Console.WriteLine("\nSort Deck by ID:");
            myDeck.ShowDeck("id");
        }
    }


    //Metadata of Cards -----------------------------------------------------//
    class Card
    {
        //Properties and static variables -----------------------------------//
        public int ID       { get; set; }
        public string Name  { get; set; }
        public int Value    { get; set; }

        public static List<int> IDs = new List<int>();


        //No parameters Constructor -----------------------------------------//
        public Card()
        {
            //Generates a random r//
            int r = Random.random.Next(26);

            //Sets first card ID to 0 and adds value to used IDs//
            if (IDs.Count == 0)
            {
                ID = 0;
                IDs.Add(0);
                Name = ((char)('a' + r)).ToString();
            }
            else
            {
                //ID of the new card = previous card ID + 1//
                IDs.Add(IDs[IDs.Count - 1] + 1);

                //Name = random letter (a + 1 = b, etc.)//
                //Value = random number//
                ID    =           IDs[IDs.Count - 1];
                Name  = ((char)('a' + r)).ToString();
                Value = Random.random.Next(1, Deck.DefaulDeckSize);
            }
        }


        //Constructor ID, Value ---------------------------------------------//
        public Card(int id, string name, int value)
        {
            //If ID is already in use uses the next one//
            while (IDs.Contains(id))
            {
                id++; 
            }

            //Now the unique ID is on use//
            IDs.Add(id);

            ID    =    id;
            Name  =  name;
            Value = value;
        }
    }


    //Deck Class Stores Cards and Related Methods ---------------------------//
    class Deck
    {
        //Parameters and static variables -----------------------------------//
        public List<Card> Cards { get; set; }
        public string DeckName  { get; set; }
        private int CardCount   { get; set; }

        public static readonly int DefaulDeckSize = 100;


        //No Parameters Constructor -----------------------------------------//
        public Deck()
        {
            Cards     = new List<Card>();
            DeckName  =    "DefaultDeck";
            CardCount =   DefaulDeckSize;

            for (int i = 0; i < CardCount; i++)
            {
                Cards.Add(new Card());
            }
        }


        //Constructor deckname, deck, cardcount -----------------------------//
        public Deck(string deckname, List<Card> deck, int cardCount)
        {
            Cards     =      deck;
            DeckName  =  deckname;
            CardCount = cardCount;

            for (int i = 0; i < CardCount; i++)
            {
                Cards.Add(deck[i]);
            }
        }

        //Constructor deckname ----------------------------------------------//
        public Deck(string deckname)
        {
            Cards     = new List<Card>();
            DeckName  =    "DefaultDeck";
            CardCount =   DefaulDeckSize;

            for (int i = 0; i < CardCount; i++)
            {
                Cards.Add(new Card());
            }
        }


        //Shuffle -----------------------------------------------------------//
        public static void Shuffle(Deck deck)
        {
            deck.Cards = ShuffleCardList(deck.Cards);
        }
        public void Shuffle()
        {
            Cards = ShuffleCardList(Cards);
        }

        //Shuffle Helper Method//
        private static List<Card> ShuffleCardList(List<Card> cards)
        {
            for (int i = 0; i < cards.Count(); i++)
            {
                Card temp = cards[i];
                int rand = Random.random.Next(i, cards.Count);

                cards[i] = cards[rand];
                cards[rand] = temp;
            }

            return cards;
        }


        //Show Deck on Screen -----------------------------------------------//
        //Overloads//
        public void ShowDeck()
        {
            Console.WriteLine(PrintCardList(Cards, "name"));
        }
        public void ShowDeck(string cardProperty)
        {
            Console.WriteLine(PrintCardList(Cards, cardProperty));
        }
        public static void ShowDeck(Deck deck)
        {
            Console.WriteLine(PrintCardList(deck.Cards, "name"));
        }
        public static void ShowDeck(Deck deck, string cardProperty)
        {
            Console.WriteLine(PrintCardList(deck.Cards, cardProperty));
        }

        //Show Deck Helper Method//
        private static StringBuilder PrintCardList(List<Card> list, string cardProperty)
        {
            StringBuilder deckStringBuilder = new StringBuilder();

            //Will show cards desired property
            switch (cardProperty.ToLower())
            {
                case "name":
                    foreach (var item in list)
                    {
                        deckStringBuilder.Append(item.Name + " ");
                    }
                    break;
                case "id":
                    foreach (var item in list)
                    {
                        deckStringBuilder.Append(item.ID + " ");
                    }
                    break;
                case "value":
                    foreach (var item in list)
                    {
                        deckStringBuilder.Append(item.Value + " ");
                    }
                    break;
                default:
                    break;
            }

            return deckStringBuilder;
        }


        //Sort Deck ---------------------------------------------------------//
        //Overloads//
        public void SortDeck()
        {
            //If not specified will sort by ID//
            SortCardList(Cards, "ID");
        }
        public void SortDeck(string sortBy)
        {
            SortCardList(Cards, sortBy);
        }
        public static void SortDeck(Deck deck)
        {
            //If not specified will sort by ID//
            SortCardList(deck.Cards, "ID");
        }
        public static void SortDeck(Deck deck, string sortBy)
        {
            SortCardList(deck.Cards, sortBy);
        }

        //Sort Deck Helper Method//
        private static List<Card> SortCardList(List<Card> cardList, string sortBy)
        {
            //Will compare and sort by one on the following words
            switch (sortBy.ToLower())
            {
                case "value":
                    cardList = cardList.OrderBy(x => x.Value).ToList();
                    break;
                case "id":
                    cardList.Sort((x, y) => x.ID.CompareTo(y.ID));
                    break;
                case "name":
                    cardList.Sort((x, y) => x.Name.CompareTo(y.Name));
                    break;
                default:
                    break;
            }

            return cardList;
        }
    }


    //Struct for storing Random variable ------------------------------------//
    struct Random
    {
        public static System.Random random = new System.Random();
    }
}
