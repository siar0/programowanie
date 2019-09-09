using System;

namespace Zadanie12
{
    public class Methods
    {
        private const double Pi = Math.PI;
        private const float PromienKola1 = 10;
        private const float PromienKola2 = 20;
        private const float PromienKola3 = 50;

        public void WypiszDane()
        {
            Console.WriteLine("Promień koła nr 1 = " + PromienKola1 + "\n" +
                              "Promień koła nr 2 = " + PromienKola2 + "\n" +
                              "Promień koła nr 3 = " + PromienKola3 + "\n");

            Console.ReadKey();
        }

        public void PokazWyliczenia()
        {
            Console.WriteLine("Koło 1: Obwód = " + ObliczObwod(PromienKola1) +
                              " Pole = " + ObliczPole(PromienKola1));

            Console.WriteLine("Koło 2: Obwód = " + ObliczObwod(PromienKola2) +
                              " Pole = " + ObliczPole(PromienKola2));

            Console.WriteLine("Koło 3: Obwód = " + ObliczObwod(PromienKola3) +
                              " Pole = " + ObliczPole(PromienKola3));
        }

        public double ObliczObwod(float promien)
        {
            return 2 * Pi * promien;
        }

        public double ObliczPole(float promien)
        {
            return Pi * Math.Pow(promien, 2);
        }

    }
}
