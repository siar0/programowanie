using System;

namespace Zadanie1
{
    public class Methods
    {
        private string _name, _lastname, _specialization, _year, _university, _date, _hobby;

        public void GetDataFromUser()
        {
            Console.WriteLine("Podaj imie: ");
            _name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            _lastname = Console.ReadLine();

            Console.WriteLine("Podaj kierunek studiow: ");
            _specialization = Console.ReadLine();

            Console.WriteLine("Podaj rocznik studiow: ");
            _year = Console.ReadLine();

            Console.WriteLine("Podaj nazwę uczelni: ");
            _university = Console.ReadLine();

            Console.WriteLine("Podaj dzisiejszą datę: ");
            _date = Console.ReadLine();

            Console.WriteLine("Jakie jest Twoje hobby?: ");
            _hobby = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);
        }

        public void ShowUserData()
        {
            Console.WriteLine("Dane, ktore podales to: " + "\n");
            Console.WriteLine("Twoje imię: " + _name + "\n"
                              + "Twoje nazwisko: " + _lastname + "\n"
                              + "Twój kierunek studiów: " + _specialization + "\n"
                              + "Twój rocznik: " + _year + "\n"
                              + "Twoja uczelnia: " + _university + "\n"
                              + "Dzisiejsza data: " + _date + "\n"
                              + "Twoje hobby: " + _hobby);

            Console.ReadKey();
        }

    }
}
