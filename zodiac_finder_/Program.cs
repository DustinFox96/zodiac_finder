using System;

namespace zodiac_finder_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();

            Console.WriteLine("How old are you");
            var age = Console.ReadLine();

            Console.WriteLine("What Day were you born on?");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your birth month?");
            var month = Console.ReadLine();

           

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("your birth day is: {0}", day);
            Console.WriteLine("Your birth month is: {0}", month);


            #region format one
            //if(month == "january")
            //{
            //    Console.WriteLine("Your Horoscope sign Is Capricorn or Aquarius.");
            //}
            //if(month == "february")
            //{
            //    Console.WriteLine("Your Horoscope sign is Aquarius or Pisces.");
            //}
            //if(month == "march")
            //{
            //    Console.WriteLine("Your Horoscope sign is Pisces or Aries.");
            //}
            //if (month == "april")
            //{
            //    Console.WriteLine("Your Horoscope sign is Aries or Taurus.");
            //}
            //if (month == "may")
            //{
            //    Console.WriteLine("Your Horoscope sign is Taurus or Gemini.");
            //}
            //if (month == "june" && Day > 15)
            //{
            //    Console.WriteLine("Your Horoscope sign is Gemini or Cancer.");
            //}
            //if (month == "july")
            //{
            //    Console.WriteLine("Your Horoscope sign is Cancer or Leo.");
            //}
            //if (month == "august")
            //{
            //    Console.WriteLine("Your Horoscope sign is Leo or Virgo.");
            //}
            //if (month == "september")
            //{
            //    Console.WriteLine("Your Horoscope sign is Virgo or Libra.");
            //}
            //if (month == "october")
            //{
            //    Console.WriteLine("Your Horoscope sign is Libra or Scorpio.");
            //}
            //if (month == "november")
            //{
            //    Console.WriteLine("Your Horoscope sign is Scorpio or Sagittarius.");
            //}
            //if (month == "december")
            //{
            //    Console.WriteLine("Your Horoscope sign is Sagittarius or Capricorn.");
            //}
            #endregion


            #region format two
            if(month == "january" && day <= 19)
            {
                Console.WriteLine("Your Horoscope sign is Capricorn");
            } else if(month == "january" && day >= 20)

            {
                Console.WriteLine("Your Horoscope sign is Aquarius");
            }
            else if (month == "february" && day <= 18)
            {
                Console.WriteLine("Your Horoscope sign is Aquarius");
            }
            else if (month == "february" && day >= 19)
            {
                Console.WriteLine("Your Horoscope sign is Pisces");
            }


            else if (month == "march" && day <= 20)
            {
                Console.WriteLine("Your Horoscope sign is Pieces");
            }
            else if (month == "march" && day >= 21)
            {
                Console.WriteLine("Your Horoscope sign is Aries");
            }


            else if (month == "april" && day <= 19)
            {
                Console.WriteLine("Your Horoscope sign is Aries");
            }
            else if (month == "april" && day >= 20)
            {
                Console.WriteLine("Your Horoscope sign is Taurus");
            }


            else if (month == "may" && day <= 20)
            {
                Console.WriteLine("Your Horoscope sign is Taurus");
            }
            else if (month == "may" && day >= 21)
            {
                Console.WriteLine("Your Horoscope sign is Gemini");
            }


            else if (month == "june" && day <= 20)
            {
                Console.WriteLine("Your Horoscope sign is Gemini");
            }
            else if (month == "june" && day >= 21)
            {
                Console.WriteLine("Your Horoscope sign is Cancer");
            }


            else if (month == "july" && day <= 22)
            {
                Console.WriteLine("Your Horoscope sign is Cancer");
            }
            else if (month == "july" && day >= 23)
            {
                Console.WriteLine("Your Horoscope sign is Leo");
            }

            else if (month == "august" && day <= 22)
            {
                Console.WriteLine("Your Horoscope sign is Leo");
            }
            else if (month == "august" && day >= 23)
            {
                Console.WriteLine("Your Horoscope sign is Virgo");
            }


            else if (month == "september" && day <= 22)
            {
                Console.WriteLine("Your Horoscope sign is Virgo");
            }
            else if (month == "september" && day >= 23)
            {
                Console.WriteLine("Your Horoscope sign is Libra");
            }


            else if (month == "october" && day <= 22)
            {
                Console.WriteLine("Your Horoscope sign is Libra");
            }
            else if (month == "october" && day >= 23)
            {
                Console.WriteLine("Your Horoscope sign is Scropio");
            }


            else if (month == "november" && day <= 21)
            {
                Console.WriteLine("Your Horoscope sign is Scropio");
            }
            else if (month == "november" && day >= 22)
            {
                Console.WriteLine("Your Horoscope sign is Sagittarius");
            }


            else if (month == "december" && day <= 21)
            {
                Console.WriteLine("Your Horoscope sign is Sagittarius");
            }
            else if (month == "december" && day >= 22)
            {
                Console.WriteLine("Your Horoscope sign is Capricorn");
            }

            #endregion
        }
    }
}
