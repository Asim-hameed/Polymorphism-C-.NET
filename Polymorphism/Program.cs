namespace Polymorphism
{
    class Program
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Add(int a, double b)
        {
            Console.WriteLine(a+b);
        }
        public void Add()
        {

        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Add(2,5);
            program.Add(3,4.777);
        }
    }
}