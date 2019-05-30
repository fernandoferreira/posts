using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factoty = null;
            Console.WriteLine("Enter your card type (Visa or Master):");
            string card = Console.ReadLine();

            switch (card.ToLower())
            {
                case "visa":
                    factoty = new VisaCreditCardFactory(1000, 0);
                    break;
                case "master":
                    factoty = new MasterCreditCardFactory(5000, 150);
                    break;
                default:
                    factoty = new VisaCreditCardFactory(1000, 0);
                    break;
            }

            Creditard myCard = factoty.GetCreditCard();

            System.Console.WriteLine($"Your credit card is {myCard.CardType} with the limit: {myCard.CreditLimit}");


            Console.ReadKey();
        }
    }
}
