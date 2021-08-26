using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyReflection
{
    class Student
    {
        //library properties
        public int ID { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }

        //constructor for the class
        public Student(int id, string name, double fees)
        {
            this.ID = id;
            this.Name = name;
            this.Fees = fees;
        }

        //second constructor to instaniate the values
        public Student()
        {
            ID = 101;
            Name = "Tshegofatso";
            Fees = 50000.00;
        }

        //methods
        public void printID()
        {
            Console.WriteLine("ID: " + ID);
        }

        public void printName()
        {
            Console.WriteLine("Name: " + Name);
        }

        public void printFees()
        {
            Console.WriteLine("Fees: " + Fees);
        }
    }
}
