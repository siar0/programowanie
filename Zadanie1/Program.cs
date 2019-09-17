namespace Zadanie1
{
    public class Program
    {
        static void Main()
        {
            var userDataInputService = new UserDataStorageService();

            var userData = userDataInputService.GetDataFromUser();

            userData.Print();
        }
    }
}
