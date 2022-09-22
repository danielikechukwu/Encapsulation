using System;

    namespace Encapsulation
    {

    class Area

    {

        public double length;
        public double width;

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length {0} : ", length);
            Console.WriteLine("Width {0} : ", width);
            Console.WriteLine("Total Area {0} : ", GetArea());

        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            Area area = new Area();
            area.length = 3;
            area.width = 4;
            area.Display();
            Console.ReadLine();

        }
    }
}