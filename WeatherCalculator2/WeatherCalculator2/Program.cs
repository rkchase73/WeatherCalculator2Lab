using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Weather Calculator 2");

            Console.WriteLine("Enter the Temperature");
            int TempF = int.Parse(Console.ReadLine());
           

            if (TempF >= 50)
            {
                Console.WriteLine("Enter the Relative Humidity");
                int RH = int.Parse(Console.ReadLine());

                double HI = 0.5 *( TempF + 61 + ((TempF - 68)*1.2) + (RH*0.094));
                Console.WriteLine("The Heat Index is " + HI);
            }
            else
            {
                Console.WriteLine("Enter the Wind Speed");
                int WindSped = int.Parse(Console.ReadLine());
                double pow_ab = Math.Pow(WindSped, 0.16);

                double WindChill = 35.74 + 0.6215 * TempF - 35.75 * pow_ab + 0.4275 * TempF * pow_ab;
                Console.WriteLine("The Wind Chill is: " + WindChill);
            }

        }
    }
}
