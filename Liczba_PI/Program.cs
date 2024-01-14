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

        int start = Environment.TickCount; // Początkowy czas

        for (int i = 0; i < precision; i++)
        {
            double x = (random.NextDouble() - 0.5) * 2; // Losujemy punkt w zakresie [-1, 1]
            double y = (random.NextDouble() - 0.5) * 2;

            double distance = Math.Sqrt(x * x + y * y);

            if (distance <= 1)
            {
                pointsInsideCircle++;
            }
        }

        int stop = Environment.TickCount; // Końcowy czas
        int elapsedTime = stop - start; // Czas obliczeń w milisekundach

        double piApproximation = 4.0 * pointsInsideCircle / precision;

        Console.WriteLine($"Przybliżona wartość liczby Pi: {piApproximation}");
        Console.WriteLine($"Czas obliczeń: {elapsedTime} ms");

        Console.ReadLine(); // Zatrzymuje konsolę przed zamknięciem
    }
}
