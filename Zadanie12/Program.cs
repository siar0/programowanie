namespace Zadanie12
{
    public class Program
    {
        private static Methods _actions;

        private static void Main(string[] args)
        {
            _actions = new Methods();
            _actions.WypiszDane();
            _actions.PokazWyliczenia();
        }
    }
}
