namespace Polymorphism
{
    class overloading
    {
        public string str;
        public int num;

        public static overloading operator +(overloading o1, overloading o2)
        {
            overloading overloading = new overloading();
            overloading.str = o1.str+" " + o2.str;
            overloading.num = o1.num+o2.num;
            return overloading;
        }
    }
    class Program
    {
        //Method Overloading starts here
        public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        public void Add(int a, double b)
        {
            Console.WriteLine(a+b);
        }
        public void Add(string a,string b)
        {

        }
        //Method Overloading ends here


        //Operator Overloading starts here



        //operator Overloading ends here


        static void Main(string[] args)
        {
            Program program = new Program();
            //Method Overloading starts here
            
            //program.Add(2,5);
            //program.Add(3,4.777);
            
            //Method Overloading ends here

            
            //Operator Overloading starts here

            overloading overloading = new overloading();
            overloading.str = "Asim";
            overloading.num = 100;

            overloading overlaoding1 = new overloading();
            overlaoding1.str = "Hameed";
            overlaoding1.num= 200;

            overloading overloading2 = new overloading();
            overloading2 = overloading + overlaoding1;
            Console.WriteLine(overloading2.str);
            Console.WriteLine(overloading2.num);

            //operator Overloading ends here

        }
    }
}