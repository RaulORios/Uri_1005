using System;
using System.Globalization;

namespace Uri_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal A = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            decimal B = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pesoA = 3.5;
            double pesoB = 7.5;
            double somapesos = pesoA + pesoB;

            double mediaA = ((double) A * pesoA);
            double mediaB = ((double) B * pesoB);

            double tot_media = (mediaA + mediaB) / somapesos;

            Console.WriteLine($"MEDIA = {tot_media.ToString("F5", CultureInfo.InvariantCulture)}");

        }
    }
}
