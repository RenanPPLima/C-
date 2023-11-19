namespace CursoCSharp.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar() {
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415; ---> IT'S a "const" so it can be altered.
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("The area is: " + area);
            Console.WriteLine("The area + test value is: " + (area + 2000));

            // Internal Types
            bool isItRaining = true;
            Console.WriteLine("Is it raining?");
            Console.WriteLine(isItRaining);

            byte age = 45;
            Console.WriteLine("Age: " + age);

            sbyte goalDifference = sbyte.MinValue;
            Console.WriteLine("The Goal Difference is: " + goalDifference);

            short salary = short.MaxValue;
            Console.WriteLine("The Salary is: " + salary);

            int minIntValue = int.MinValue;
            Console.WriteLine("Minimum Int: " + minIntValue);

            uint brazilianPopulation = 207_600_000; // we can use underscore to make it better to visualize the number.
            Console.WriteLine("The Brazilian Population is: " + brazilianPopulation);

            long minLongValue = long.MinValue;
            Console.WriteLine("Minimum Long Value: " + minLongValue);

            ulong worldPopulation = 7_600_000_000;
            Console.WriteLine("The World's Population is: " + worldPopulation);

            float computerPrice = 1299.99f;
            Console.WriteLine("The Computer Price is: $" + computerPrice);

            double appleMarketValue = 1_000_000_000_000.00; // MOST COMMONLY USED FOR DECIMALS.
            Console.WriteLine("The Market Value of Apple is: $" + appleMarketValue);

            decimal distanceBetweenStars = decimal.MaxValue;
            Console.WriteLine("The Distance Between the Stars is: " + distanceBetweenStars);

            char forLetter = 'b';
            Console.WriteLine("Armazenar uma letra, 'char': " + forLetter);

            string forTexts = "Welcome to the C# course!";
            Console.WriteLine(forTexts);

        }
    }
}