//Console.WriteLine("Hello, OS");

namespace UseOfBaseKeyword
{
    
    class A
    {
        public A (int number)
        {
            Console.WriteLine($"A Class constructor is called : {number}");
        }
    }

    class B : A
    {
        public B () : base(4)
        {
            Console.WriteLine($"B Class constructor is called");
        }

        
    }

    // How to pass dynamic value to Parent class constructor in C#
    class C
    {
        public C (int number)
        {
            Console.WriteLine($"Class C Constructor is called : {number}");
        }
    }

    class D : C
    {
        public D (int number) : base(number)
        {
            Console.WriteLine($"Class D Constructor is called : {number}");
        }

        static void Main(string[] args)
        {
            B b = new B();
            D d = new D(4);
        }
    }
}