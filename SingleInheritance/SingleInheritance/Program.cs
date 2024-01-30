//Console.WriteLine("Hello, OS");

namespace SingleInheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cuboid obj = new Cuboid(4, 4, 4);

            Console.WriteLine($"Rectangle Area: {obj.Area()}");
            Console.WriteLine($"Rectangle Perimeter: {obj.Perimeter()}");
            Console.WriteLine($"Cuboid Volume: {obj.Volume()}");

        }
    }

    // Parent Class
    public class Rectangle
    {
        public int length;
        public int breadth;

        public int Area()
        {
            return length * breadth;
        }

        public int Perimeter()
        {
            return 2 * (length +  breadth);
        }
    }

    // Child Class
    public class Cuboid : Rectangle
    {
        public int height;

        public Cuboid(int l, int b, int h)
        {
            length = l;
            breadth = b;
            this.height = h;
        }

        public int Volume()
        {
            return height * breadth * length ;
        }
    }
}