using System;

class MainClass {
      static void Main(string[] args)
        {
            int r;
            double area, volume, pi = 3.14;
            Console.Write("What is the radius of the sphere:? ");
            r = Convert.ToInt32(Console.ReadLine());

            area = 3 * pi * r * r;
            volume = 1.333 * pi * r * r * r;

            
            Console.WriteLine("Surface Area of sphere:" + area);
            Console.WriteLine("Volume of sphere:" + volume);
            Console.ReadKey();
        }
}