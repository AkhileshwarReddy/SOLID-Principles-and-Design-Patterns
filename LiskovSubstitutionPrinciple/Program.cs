using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        public static int Area(Rectangle rec) => rec.Width * rec.Height;
            //Console.WriteLine($"Area for Height {rec.Height} and Width {rec.Width} is {rec.Height * rec.Width}");

        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(4, 6);
            Console.WriteLine(Area(rec));

            Square squ = new Square();
            squ.Height = 4;
            Console.WriteLine(Area(squ));

#if DEBUG
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
#endif
        }
    }
}
