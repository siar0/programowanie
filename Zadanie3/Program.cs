namespace Zadanie3
{
    public class Program
    {
        private static Methods _actions;
        private static void Main()
        {
            _actions = new Methods();

            _actions.GetUserData();
            _actions.ReturnUserData();

        }
    }
}
