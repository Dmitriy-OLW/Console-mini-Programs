using System;

namespace Graviti_Finder_1 {

    class Program1 {

        static void Main() 
        {
            System.Console.WriteLine("Программа нахождения ускорения свободного падения любой планеты.");
            double gs = 6.7;
            double a = 10;
            double G = gs / Math.Pow(a, 11);

            double MasZem, MasStep;
            System.Console.WriteLine("Введиде массу объекта в кг (первые цифры): ");
            MasZem = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введиде массу объекта (Степень десятки): ");
            MasStep = Convert.ToDouble(System.Console.ReadLine());

            double Radius, RadStep;
            System.Console.WriteLine("Введиде радиус объекта в метрах (первые цифры): ");
            Radius = Convert.ToDouble(System.Console.ReadLine());
            System.Console.WriteLine("Введиде радиус объекта (Степень десятки): ");
            RadStep = Convert.ToDouble(System.Console.ReadLine());
            double RadO = Radius * Math.Pow(10, RadStep);

            double g = G * MasZem * Math.Pow(10, MasStep)  / Math.Pow(RadO, 2);
            System.Console.WriteLine("Ускорение свободного падения равно: {0} м/с^2", g);
            System.Console.ReadKey();
        }


    }
}


