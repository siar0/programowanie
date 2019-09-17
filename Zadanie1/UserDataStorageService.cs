using System;

namespace Zadanie1
{
    public class UserDataStorageService
    {
        public UserDataModel GetDataFromUser()
        {
            Console.WriteLine("Podaj imie: ");
            var name = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            var lastname = Console.ReadLine();

            Console.WriteLine("Podaj kierunek studiow: ");
            var specialization = Console.ReadLine();

            Console.WriteLine("Podaj rocznik studiow: ");
            var year = Console.ReadLine();

            Console.WriteLine("Podaj nazwę uczelni: ");
            var university = Console.ReadLine();

            Console.WriteLine("Podaj dzisiejszą datę: ");
            var date = Console.ReadLine();

            Console.WriteLine("Jakie jest Twoje Hobby?: ");
            var hobby = Console.ReadLine();

            Console.WriteLine(Environment.NewLine);

            return new UserDataModel(name, lastname, specialization, year, university, date, hobby);
        }
    }
}
