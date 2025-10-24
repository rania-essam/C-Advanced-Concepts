using System.Security.Cryptography.X509Certificates;

namespace ANONYMS_TYPE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //anonymous type ---> class that has no name that can contain public read_only_properties
            //It cannot contain other members, such as fields, methods, events

            #region anonyms type
            var Student = new { id = 8, name = "rania" };
            Console.WriteLine(Student.name);

            // an anonyms type property can contain another anonymys type
            var ob = new
            {
                id = 9,
                name = "rania",
                Address = new { id = 2, city = "cairo", country = "US" }
            };
            Console.WriteLine(ob.Address.id);

            // you can create array of anonymys type
            var students = new[]
            {
                new{id=2,name="rania"},
                new{id=2,name="sara"},
                new{id=2,name="essam"}
            }; 
            #endregion

           // delegates ---> reference datatype that defines the method signature 
           



        }
    }
}

// anonymous ---> readonly ---> cannot be initialized with a null ,
// or anonymous function, or a pointer type
