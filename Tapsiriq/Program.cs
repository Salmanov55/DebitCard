using System;

namespace Tapsiriq
{
    internal class Program
    {
        class DebitCard
        {
            public string CardNumber { get; set; }
            public int CVV { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string PersonName { get; set; }
            public string Surname { get; set; }
            public string CompanyName { get; set; }
            public decimal Balance { get; set; }

            public DebitCard(string cardNumber, string cvv, DateTime expiryDate, string personName,string surname, string companyName, decimal balance)
            {
                if (cardNumber.Length != 16)
                {
                    Console.WriteLine("Card number must be 16 digits.");
                }

                CardNumber = cardNumber;
                CVV = cvv;
                ExpiryDate = expiryDate;
                PersonName = personName;
                Surname = surname;
                CompanyName = companyName;
                Balance = balance;
            }

            public void DisplayCardInformation()
            {
                Console.WriteLine("Debit Card Information:");
                Console.WriteLine("Card Number: " + CardNumber);
                Console.WriteLine("CVV: " + CVV);
                Console.WriteLine("Expiry Date: " + ExpiryDate.ToString("MM/yyyy"));
                Console.WriteLine("Card Holder: " + PersonName);
                Console.WriteLine("Surname: " + Surname);
                Console.WriteLine("Company: " + CompanyName);
                Console.WriteLine("Balance: " + Balance);
            }
        }
        static void Main()
        {
            DebitCard debitCard = new DebitCard();
            debitCard.CardNumber = "1234567890123456";
            debitCard.CVV = 123;
            debitCard.ExpiryDate = new DateTime();
            debitCard.PersonName = "Ali";
            debitCard.Surname = "Salmanov";
            debitCard.CompanyName = "ABB";
            debitCard.Balance = 0;

        }
    }
}
