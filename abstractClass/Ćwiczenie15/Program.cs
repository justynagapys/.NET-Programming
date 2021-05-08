using System;

namespace Ćwiczenie15
{
    class Program
    {
        static void Main(string[] args)
        {
            Second second = new Second();
            second.f();
            second.r();
        }
    }
    public abstract class First
    {
        public abstract void f();
        public virtual void r()
        {
            Console.WriteLine("Metoda r klasy First");
        }
    }

    public class Second : First
    {
        public override void f()
        {
            Console.WriteLine("Metoda f klasy Second");
        }

        public override void r()
        {
            Console.WriteLine("Metoda r klasy Second");
        }
    }
}
