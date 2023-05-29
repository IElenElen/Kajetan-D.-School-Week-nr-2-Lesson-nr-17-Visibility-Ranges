namespace Lesson_nr_17_próba_widoczności
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visibility Internal Protected Private");

            internal int a;

            protected int b;

            private int c;

            public void Method()
        {
            c = 8;
        }

        }
    }
}