namespace Refactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account ClassicAccount = new Account { Type = "Обычный", Balance = 1200};

            var calc = InterestCalculatorFactory.ReturnDependingOnType(ClassicAccount.Type);

            calc.CalculateInterest(ClassicAccount);

            Console.WriteLine(ClassicAccount.Interest);
        }
    }
}
