using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set
            Car car1 = new Car("Ferrari", "F8", "A1");
            Car car2 = new Car("Ford", "Fiesta", "R2D2");

            Book b1 = new Book
            {
                Name   = "The Tell-Tale Heart",
                Author =     "Edgar Allan Poe",
                ISBN   =       "0-000-00000-0"
            };

            //ArrayList  are  dynamically  sized,
            //features like sorting, remove items
            /*
            System.Collections.ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */


            //List ----------------------------------------------------------//
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            //Can't add wrong type unlike ArrayList
            //myList.Add(b1);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Make);
            }


            //Dictionary ----------------------------------------------------//
            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A1"].Make);

            //Collection Initialization Syntax -------------------------------//
            //string[] names = { "Bob", "Steve", "Brian", "Chuck" };
            List<Car> myCarList = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlass Supreme", VIN = "C3P0" },
                new Car { Make = "Nissan", Model = "Altima", VIN = "F4"}
            };


            //Exit ----------------------------------------------------------//
            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make  { get; set; }
        public string Model { get; set; }
        public string VIN   { get; set; }

        public Car()
        {
        }

        public Car(string make, string model, string vin)
        {
            Model = model;
            Make  =  make;
            VIN   =   vin;
        }
    }

    class Book
    {
        public string Name   { get; set; }
        public string Author { get; set; }
        public string ISBN   { get; set; }

        public Book()
        {
        }

        public Book(string name, string author, string isbn)
        {
            Name = name;
            Author = author;
            ISBN = isbn;
        }
    }

    static class DeckTesting
    {
        //Testing Deck Class and Methods ------------------------------------//
        public static void Test()
        {
            Deck myDeck = new Deck();
            Console.Write("Deck: ");
            Deck.Show(myDeck);

            Console.Write("\nShuffle Deck: ");

            Deck.Shuffle(myDeck);
            myDeck.Show();

            Console.Write("\nSort Deck: ");

            myDeck.Cards.Sort();
            myDeck.Show();
        }
    }

    class Card
    {
        public int ID    { get; set; }
        public int Value { get; set; }
    }

    //Deck Class stores Cards and functions related to it -------------------//
    class Deck
    {
        public List<Card> Cards     { get; set; }
        public string     DeckName  { get; set; }
        private int       CardCount { get; set; }

        public Deck()
        {
            Cards     = new List<Card>();
            DeckName  = "DefaultDeck";
            CardCount = 42;

            for (int i = 0; i < CardCount; i++)
            {
                Cards.Add(new Card());
            }
        }

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

        public static List<Card> Shuffle(Deck deck)
        {
            return ShuffleCards(deck.Cards);
        }

        public List<Card> Shuffle()
        {
            return ShuffleCards(Cards);
        }

        private static List<Card> ShuffleCards(List<Card> cards)
        {
            Random random = new Random();

            for (int i = 0; i < cards.Count(); i++)
            {
                Card temp = cards[i];
                int rand = random.Next(i, cards.Count);

                cards[i]    = cards[rand];
                cards[rand] = temp;
            }

            return cards;
        }

        public static void Show(Deck deck)
        {
            Console.WriteLine(PrintList(deck.Cards));
        }

        public void Show()
        {
            Console.WriteLine(PrintList(Cards));
        }

        private static string PrintList(List<Card> list)
        {
            StringBuilder deckString = new StringBuilder();

            foreach ( var item in list )
            {
                deckString.Append(item.Value + " ");
            }

            return deckString.ToString();
        }
    }
}