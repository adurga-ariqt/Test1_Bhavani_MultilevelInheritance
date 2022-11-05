using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Bhavani_MultilevelInheritance
{
    public class Student
    {
        public int Id { get; set; }
        public string SName { get; set; }
        public string  Gender { get; set; }
        public  string address { get; set; }
        public string Standerd { get; set; }
        public string Section { get; set; }

        public void StudentMethod()
        {
            Console.WriteLine("Enter student name:");
            SName = Console.ReadLine();
            Console.WriteLine(" Enter student id :");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Gender :");
            Gender = Console.ReadLine();
            Console.WriteLine("Enter Address :");
            address = Console.ReadLine();
            Console.WriteLine("Enter Standerd :");
            Standerd= Console.ReadLine();
            Console.WriteLine("Enter section  :");
            Section = Console.ReadLine();


        }
    }
}
