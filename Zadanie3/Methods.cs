using System;

namespace Zadanie3
{
    public class Methods
    {
        private string _imie, _nazwisko, _kierunek, _rocznik, _uczelnia, _data, _hobby;

        public void GetUserData()
        {
            Console.WriteLine("Podaj imie: ");
            _imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            _nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj kierunek studiow: ");
            _kierunek = Console.ReadLine();

            Console.WriteLine("Podaj rocznik studiow: ");
            _rocznik = Console.ReadLine();

            Console.WriteLine("Podaj nazwę uczelni: ");
            _uczelnia = Console.ReadLine();

            Console.WriteLine("Podaj dzisiejszą datę: ");
            _data = Console.ReadLine();

            Console.WriteLine("Jakie jest Twoje hobby?: ");
            _hobby = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);
        }

        public void ReturnUserData()
        {
            Console.WriteLine("Dane, ktore podales to: " + "\n");
            Console.WriteLine("Twoje imię: " + _imie + "\n"
                              + "Twoje nazwisko: " + _nazwisko + "\n"
                              + "Twój kierunek studiów: " + _kierunek + "\n"
                              + "Twój rocznik: " + _rocznik + "\n"
                              + "Twoja uczelnia: " + _uczelnia + "\n"
                              + "Dzisiejsza data: " + _data + "\n"
                              + "Twoje hobby: " + _hobby);

            Console.ReadKey();
        }
    }
}
