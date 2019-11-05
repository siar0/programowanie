using System;

namespace Zadanie4._2
{
    public class Methods
    {
        private const int maxValue = 33;
        private int storageValue = 0;

        public void GetDataFromUser()
        {

            if(storageValue < maxValue)
            {
                Console.WriteLine("Wpisz wartość");
                var value = Int32.Parse(Console.ReadLine());
                storageValue =+ value;
                Console.WriteLine($"aktualna wartosc w store to: {storageValue}");
            }

            do
            {
                var value = Int32.Parse(Console.ReadLine());
                storageValue =+ value;
                Console.WriteLine(storageValue);

            } while (storageValue < maxValue);
        }
    }
}
