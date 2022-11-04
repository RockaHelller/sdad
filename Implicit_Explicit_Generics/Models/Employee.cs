using System;
using System.Collections.Generic;
using System.Text;

namespace Implicit_Explicit_Generics.Models
{
    class Employee
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }
        public double Salary { get; set; }



        public Employee(DateTime birthday, double salary)
        {
            BirthDay = birthday;
            Salary = salary;


            //static void GetEmployeeDate(DateTime start, DateTime end)
            //{
            //    Employee[] emps = { new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500) };
            //    int cnt = 0;
            //    for (int i = 0; i < emps.Length; i++)
            //    {

            //        if ((emps[i].BirthDay > start && emps[i].BirthDay < end) && emps[i].Salary > 2000)
            //        {
            //            cnt++;
            //        }
            //    }
            //    Console.WriteLine(cnt);
            //}


        }

        //public static void GetEmployeeDate(DateTime start, DateTime end)
        //{
        //    Employee[] emps = { new Employee(new DateTime(2015, 12, 31), 2500) };

        //    for (int i = 0; i < emps.Length; i++)
        //    {

        //        if ((emps[i].BirthDay > start && emps[i].BirthDay < end) && emps[i].Salary > 2000)
        //        {
        //            Console.WriteLine("Yes");
        //        }
        //        else
        //        {
        //            Console.WriteLine("No");
        //        }
        //    }
        //}

        //public static void GetEmployeeDate(DateTime start, DateTime end)
        //{
        //    Employee[] emps = { new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500), new Employee(new DateTime(2015, 12, 31), 2500) };
        //    int cnt = 0;
        //    for (int i = 0; i < emps.Length; i++)
        //    {

        //        if ((emps[i].BirthDay > start && emps[i].BirthDay < end) && emps[i].Salary > 2000)
        //        {
        //            cnt++;
        //        }
        //    }
        //    Console.WriteLine(cnt);
        //}



    }
}
