using System;

namespace Zadanie1
{
    public class UserDataModel
    {
        private readonly string _name;
        private readonly string _lastname;
        private readonly string _specialization;
        private readonly string _year;
        private readonly string _university;
        private readonly string _date;
        private readonly string _hobby;

        public UserDataModel(string name, string lastname, string specialization, string year, string university, string date, string hobby)
        {
            _name = name;
            _lastname = lastname;
            _specialization = specialization;
            _year = year;
            _university = university;
            _date = date;
            _hobby = hobby;
        }
        public void Print() {
            Console.WriteLine("Dane, ktore podales to: " + "\n");
            Console.WriteLine("Twoje imię: " + _name + "\n"
                              + "Twoje nazwisko: " + _lastname + "\n"
                              + "Twój kierunek studiów: " + _specialization + "\n"
                              + "Twój rocznik: " + _year + "\n"
                              + "Twoja uczelnia: " + _university + "\n"
                              + "Dzisiejsza data: " + _date + "\n"
                              + "Twoje Hobby: " + _hobby);

            Console.ReadKey();
        }
    }
}
