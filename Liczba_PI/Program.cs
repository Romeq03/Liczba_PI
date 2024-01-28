using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Obliczanie liczby Pi za pomocą metody Monte Carlo");

        Console.Write("Podaj dokładność (liczbę punktów): ");
        int precision = Convert.ToInt32(Console.ReadLine());

        int pointsInsideCircle = 0;
        Random random = new Random();

        int start = Environment.TickCount;

        for (int i = 0; i < precision; i++)
        {
            double x = (random.NextDouble() - 0.5) * 2;
            double y = (random.NextDouble() - 0.5) * 2;

            double distance = Math.Sqrt(x * x + y * y);

            if (distance <= 1)
            {
                pointsInsideCircle++;
            }
        }

        int stop = Environment.TickCount;
        int elapsedTime = stop - start;

        double piApproximation = 4.0 * pointsInsideCircle / precision;

        Console.WriteLine($"Przybliżona wartość liczby Pi: {piApproximation}");
        Console.WriteLine($"Czas obliczeń: {elapsedTime} ms");

        Console.ReadLine();
    }
}
