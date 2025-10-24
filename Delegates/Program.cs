namespace ConsoleAppc_abvanced
{

    public delegate void first_delegate(string s);
    public delegate int rectangle(int length, int width);
    internal class Program
    {
        static void Main(string[] args)
        {

            #region delegate
            // Assigning a Delegate a method 

            //first_delegate d1 = Method1;
            ////or
            //first_delegate d2 = new first_delegate(Method2);
            //first_delegate d3 = Method3;

            //// or 
            //d1 = (string s)=>Console.WriteLine($"The string is : + {s}" );


            //first_delegate multi_cast = d1 + d2; // combines 
            //multi_cast("rrr");


            //// passing parameter values 


            ////multi_cast += d3;// combines d1 , d2 , d3 

            ////multi_cast("Heyyyyyyyyyy");
            ////Console.WriteLine("---------------------");
            ////multi_cast -= d1;// removes d1 from multicast 

            ////multi_cast("Heyyyyyyyyyy");

            //////d3.Invoke("Raniaaaa Specialist ");
            ////////or
            //////d1("Specilaisttttt ");

            ////// passing delegate as a parameter 
            //////     Invoke_Delegate(d1);
            ////Console.WriteLine("---------------------");
            ////multi_cast -= d2; // removes d2
            ////multi_cast("Heyyyyyyyyyy"); 
            #endregion


            // problem : you have  three methods has the same implementation but the difference between them is a condition 
            // you can replace this condition with a delegate 

            Employee[] emp = new Employee[]
            {
                new Employee{ID = 1 , salary=50000m, age = 21 , name ="raniaaa"},
                new Employee{ID = 2 , salary=65000m, age = 26 , name ="raniaaa"},
                new Employee{ID = 3 , salary=60000m, age = 27 , name ="raniaaa"},
                new Employee{ID = 4 , salary=70000m, age = 23 , name ="raniaaa"},
                new Employee{ID = 5 , salary=35000m, age = 28 , name ="raniaaa"},
                new Employee{ID = 6 , salary=18000m, age = 29, name ="raniaaa"},
                new Employee{ID = 7 , salary=19000m, age = 26 , name ="raniaaa"},
                new Employee{ID = 8 , salary=20000m, age = 25 , name ="raniaaa"},
                new Employee{ID = 9 , salary=40000m, age = 29 , name ="raniaaa"},
                new Employee{ID = 10 , salary=55000m, age = 30 , name ="raniaaa"},
                new Employee{ID = 11 , salary=45000m, age = 31 , name ="raniaaa"},
                new Employee{ID = 12 , salary=65000m, age = 32 , name ="raniaaa"}
            };

            Report rep = new Report();
            //rep.salarylessthan30000(emp);
            //rep.salarybiggerthan30000(emp);
            //rep.salarybetween30000and60000(emp);

            // passing function to delegate 
            //rep.salaries_report(emp, "Less than 30000", less_than_30000);
            //rep.salaries_report(emp, "bigger than 30000", bigger_than_30000);
            //rep.salaries_report(emp, "between30000and60000", between30000and60000);
            //Console.WriteLine("============================================================================================================");
            //  [  anonmyous delegate  ]
            //rep.salaries_report(emp, "Less than 30000", delegate (Employee e) {return e.salary < 30000;}             );
            //rep.salaries_report(emp, "bigger than 30000", delegate (Employee e) { return e.salary > 30000; }          );
            //rep.salaries_report(emp, "between30000and60000", delegate (Employee e){ return e.salary > 30000 && e.salary < 60000; }  );
            //Console.WriteLine("============================================================================================================");

            //// [ lamda expression ]
            //rep.salaries_report(emp, "Less than 30000", (Employee e) => e.salary < 30000);
            //rep.salaries_report(emp, "bigger than 30000", (Employee e) => e.salary > 30000);
            //rep.salaries_report(emp, "between30000and60000", (Employee e) => e.salary > 30000 && e.salary < 60000);
            //Console.WriteLine("============================================================================================================");

            //rep.salaries_report(emp, "Less than 30000", e => e.salary < 30000);
            //rep.salaries_report(emp, "bigger than 30000", e => e.salary > 30000);
            //rep.salaries_report(emp, "between30000and60000",  e => e.salary > 30000 && e.salary < 60000);

            // multicast deligate 
            rectangle rec = rect_area;
            rec += rect_circumference;
            Console.WriteLine("rect_circumference is :");
            Console.WriteLine(rec(10, 10));
            rec -= rect_circumference;
            Console.WriteLine("rect_Area is :");
            Console.WriteLine(rec(10, 10));





        }
        static void Method1(string s)
        {
            Console.WriteLine(s);
        }
        static void Method2(string s)
        {
            Console.WriteLine(s);
        }
        static void Method3(string s)
        {
            Console.WriteLine(s);
        }
        static void Invoke_Delegate(first_delegate d)
        {
            d(Console.ReadLine());
        }

        static bool less_than_30000(Employee e) =>  e.salary < 30000;
        
        static bool bigger_than_30000(Employee e) => e.salary > 30000;

        static bool between30000and60000(Employee e) => e.salary >= 30000 && e.salary <= 60000;



        // for multicast deligate 
        
        static int rect_area(int length,int width)
        {
            return length * width;
        }
        static int rect_circumference(int length, int width)
        {
            return (length + width) * 2;
        }

    }
}
