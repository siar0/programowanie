using System;

namespace Zadanie3
{
    public class Methods
    {
        private const double Pi = Math.PI;
        private const int FirstCircleRadius = 10;
        private const int SecondCircleRadius = 20;
        private const int ThirdCircleRadius = 50;

        public void ShowUserData()
        {
            Console.WriteLine("Promień koła nr 1 = " + FirstCircleRadius + "\n" +
                              "Promień koła nr 2 = " + SecondCircleRadius + "\n" +
                              "Promień koła nr 3 = " + ThirdCircleRadius + "\n");

            Console.ReadKey();
        }

        public void ShowCalculations()
        {
            Console.WriteLine("Koło 1: Obwód = " + CountCircumference(FirstCircleRadius) +
                              " Pole = " + CountCircleArea(FirstCircleRadius));

            Console.WriteLine("Koło 2: Obwód = " + CountCircumference(SecondCircleRadius) +
                              " Pole = " + CountCircleArea(SecondCircleRadius));

            Console.WriteLine("Koło 3: Obwód = " + CountCircumference(ThirdCircleRadius) +
                              " Pole = " + CountCircleArea(ThirdCircleRadius));
        }

        public double CountCircumference(int radius)
        {
            return 2 * Pi * radius;
        }

        public double CountCircleArea(int radius)
        {
            return Pi * Math.Pow(radius, 2);
        }
    }
}
