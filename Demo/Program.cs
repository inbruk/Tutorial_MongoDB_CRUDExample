using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo
{
    class Program
    {

        static void Main(String[] args)
        {
            MongoCRUD crud = new MongoCRUD("AddressBook");

            Console.WriteLine("message");
            Console.ReadLine();
        }
    }
}