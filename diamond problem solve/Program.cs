using System;

namespace diamond_problem_solve
{   interface IA
    {
        void Amethod();
    }
    class A : IA
    {
        public void Amethod() 
        {
            Console.WriteLine("A");
        }
    }
    interface IB
    {
        void Bmethod();
    }
    class B: IB
    {
        public void Bmethod()
        {
            Console.WriteLine("B");
        }
    }

    class AB : IA , IB
    {                           // MOST IMPORTANT 
        A a = new A();
        B b = new B();
        
        public void Amethod()
        {
            a.Amethod();
        }
        public void Bmethod()
        {
            b.Bmethod();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AB ab = new AB();

            ab.Amethod();
            ab.Bmethod();




        }
    }
}
