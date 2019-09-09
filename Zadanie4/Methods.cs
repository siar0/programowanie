using System;

namespace Zadanie4
{
    public class Methods
    {
        private const string CorrectlyPassword = "Pracuj123";
        private string  _enteredPassword;

        public void LoginUser()
        {
            do
            {
                GetPasswordFromUser();
                ValidatePassword();
            } while (_enteredPassword != CorrectlyPassword);
        }
        
        
        public void ValidatePassword()
        {
            if (_enteredPassword == CorrectlyPassword)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hasło poprawne, zostałeś zalogowany!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Niepoprawne hasło, spróbuj ponownie.");
                Console.ResetColor();
            }
        }
        
        public void GetPasswordFromUser()
        {
            Console.WriteLine("Podaj hasło autoryzacyjne: ");
            _enteredPassword = Console.ReadLine();
        }
    }
}