using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Customer> lists = new List<Customer>
            {
                new Customer{Name="gülsüm",LastName="aslan",CrediLimit=10},
                new Customer{Name="Mehmet",LastName="aslan",CrediLimit=15},
                new Customer{Name="Ruşen",LastName="aslan",CrediLimit=20}

            };

            var result = lists.Where(l => l.CrediLimit > 10);
            foreach (var r in result)
            {
                Console.WriteLine(r.Name);
            }


            //Manager manager = new Manager();
            //manager.Department();



            Need need = new Need();
            need.Names = "AYşe";
            need.CrediLimit = 0.6;
            Console.WriteLine("Name :"+need.Names);
            Console.WriteLine("Credi Limit:"+need.CrediLimit);



            //List<Manager> lists1 = new List<Manager>
            //{
            //    new Manager{Id=2 , Name="fatma",LastName="ayaz",CrediLimit=8}
            //};






            //List<Need> needs = new List<Need>
            //{
            //    new Need{Id=1, CrediLimit=12}
            //};
            //Need need = new Need();
            //Vehicle vehicle = new Vehicle();
            //Housing housing = new Housing();


            //List<ICredit> credits = new List<ICredit> { need, housing, vehicle };



        }
    }

    public interface IEmployees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public void Department();


    }


    public class Manager :Credit, IEmployees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double CrediLimit { get; set; }

        public void Department()
        {
            Console.WriteLine("Manager department");
        }

        public override void InterestRate()
        {
            Console.WriteLine("interest rate for manager");
        }
    }
    public class Customer : Credit
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public double CrediLimit { get; set; }

        public override void InterestRate()
        {
            Console.WriteLine("Customer interest rate");
        }

      
    }


    public abstract class Credit
    {

        public double CrediLimit { get; set; }
        public string Names { get; set; }


        public abstract void InterestRate();

    }

    public class Need : Credit
    {
        public int Id { get; set; }
        public double CrediLimit { get; set; }



        public override void InterestRate()
        {
            Console.WriteLine("consumer loan interest rate");
        }
    }

    public class Housing : Credit
    {
        public int Id { get; set; }
        public double CrediLimit { get; set; }



        public override void InterestRate()
        {
            Console.WriteLine("home loan interest rate");
        }

        public class Vehicle : Credit
        {
            public int Id { get; set; }
            public double CrediLimit { get; set; }

            public override void InterestRate()
            {
                Console.WriteLine("car loan interest rate");
            }
        }


        public class Manage
        {
            static void manage()
            {
                Console.WriteLine("to manage");


            }

            public class Inspect
            {
                static void inspect()
                {
                    Console.WriteLine("inspect");
                }
            }

        }
    }
}
