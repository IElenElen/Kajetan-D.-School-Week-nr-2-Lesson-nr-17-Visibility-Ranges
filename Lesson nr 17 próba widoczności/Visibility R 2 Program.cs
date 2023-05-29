namespace Lesson_nr_17_próba_widoczności
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visibility Internal Protected Private");

            internal int A;

            protected int B;

            private int C;

            public void Method()
        {
            C = 8;
        }

        }
    }
}