using System;

namespace CreditCard
{
    public class CreditCardException : System.Exception
    {
        public CreditCardException()
            :base()
        { }
        public CreditCardException(String message)
            :base(message)
        { }
        public CreditCardException(String message, Exception innerException)
            :base()
        { }

    }
   class Program
    {
       static void Main (string [] args) {

            CreditCard creditCard = new CreditCard();
            Console.WriteLine("Lutfen  kart numaranizi giriniz :");

            creditCard.CardNo = Console.ReadLine();
            try
            {
                if (creditCard.CardNo.Length != 16) 
                    throw new CreditCardException(" kart numaraniz 16 haneli olmalidir...");
                        
                
            }
            catch(CreditCardException crediCardException)
            {
                Console.WriteLine(crediCardException.Message);
            }
            Console.WriteLine("\n  kart uzerindeki ismi giriniz :");
            creditCard.Name = Console.ReadLine();

            Console.WriteLine("\n kart CVV numaranizi giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string sayi2 = sayi.ToString();


            try {
                if (sayi2.Length != 3)
                    throw new CreditCardException("Cvv' niz 3 haneli olmalidir...");



            }
            catch (CreditCardException crediCardException)
            {
                Console.WriteLine(crediCardException.Message);
            }
            Console.WriteLine("\n kart son kullanma tarihini giriniz :\n");
            creditCard.ExpireDate = Console.ReadLine();

            string phrase = creditCard.ExpireDate;
            string[] words = phrase.Split('/');
            int exprdateMonth = Convert.ToInt32(words[0]);
            int exprdateYear = Convert.ToInt32(words[1]);
            try
            {
                if (exprdateYear < 22)
                    throw new CreditCardException(creditCard.ExpireDate+" gecerli bir tarih degildir.07/22 den ileride bir tarih giriniz...");
                else if(exprdateYear == 22)
                    if(exprdateMonth < 07)
                        throw new CreditCardException(creditCard.ExpireDate + " gecerli bir tarih degildir.07/22 den ileride bir tarih giriniz...");


            }
            catch (CreditCardException crediCardException)
            {
                Console.WriteLine(crediCardException.Message);
            }


        }
    }
}
