namespace Polymorphism
{
    //Operator Overloading starts here

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

    //operator Overloading ends here

    //Method hiding

    //class parent
    //{
    //    public void show()
    //    {
    //        Console.WriteLine("Parent Class");
    //    }
    //}
    //class child:parent
    //{
    //    public new void show()
    //    {
    //        //base.show(); //To call parent show function
    //        Console.WriteLine("Child Class");
    //    }
    //}

    class employee
    {
        public string fname;
        public string lname;
        public void printFullName()
        {
            Console.WriteLine(fname + " " + lname);
        }
    }
    class partTimeEmployee:employee
    {
        public new void printFullName()
        {
            base.printFullName();
            //Console.WriteLine(fname + " " + lname + " PTE");
        }
    }
    class fullTimeEmployee:employee
    {
        public new void printFullName()
        {
            Console.WriteLine(fname + " " + lname + " FTE");
        }
    }

    //DYNAMIC POLYMORPHISM

    class parent
    {
        public virtual void print()
        {
            Console.WriteLine("Method of Parent class"); ;
        }
    }
    class child : parent
    {
        public override void print()
        {
            Console.WriteLine("Method of Child class"); ;
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


        


        static void Main(string[] args)
        {
            Program program = new Program();
            //Method Overloading starts here

            //program.Add(2,5);
            //program.Add(3,4.777);

            //Method Overloading ends here


            //Operator Overloading starts here

            //overloading overloading = new overloading();
            //overloading.str = "Asim";
            //overloading.num = 100;

            //overloading overlaoding1 = new overloading();
            //overlaoding1.str = "Hameed";
            //overlaoding1.num= 200;

            //overloading overloading2 = new overloading();
            //overloading2 = overloading + overlaoding1;
            //Console.WriteLine(overloading2.str);
            //Console.WriteLine(overloading2.num);

            //operator Overloading ends here


            //Method Hiding starts here

            // 1 Use base keyword
            // type casting from child to parent or vice versa
            // parent p =new child();

            //child child = new child();
            //child.show();


            //child p = new child();
            //((parent)child).show();
            //type casting
            //p.show();


            //partTimeEmployee partTimeEmployee = new partTimeEmployee();
            //partTimeEmployee.fname = "Asim";
            //partTimeEmployee.lname = "Hameed";
            //partTimeEmployee.printFullName();


            //Method Hiding ends here
            
            //STATIC POLYMORPHISM ENDS HERE........

            
            
            //.............................................
            
            
            //DYNAMIC POLYMORPHISM STARTS HERE........

            //Method Overriding
            child child = new child();
            child.print();
        }
    }
}