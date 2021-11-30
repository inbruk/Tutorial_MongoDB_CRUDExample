using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Demo
{
    class Program
    {

        static void Main(String[] args)
        {
            var adr = new AddressModel("Washington St. 23", "Albukerque", "New Mexico", "45");
            var somePers = new PersonModel("Alice", "Smith", adr);

            MongoCRUD crud = new MongoCRUD("AddressBook");

            // crud.Create("Users", somePers);
            // Console.WriteLine("============================================================");

            var recs = crud.ReadAll<PersonModel>("Users");
            foreach (var item in recs)
            {
                var iStr = JsonSerializer.Serialize(item);
                Console.WriteLine(iStr);
                Console.WriteLine("-----------------------------------------------------------");
            }

            var rec = crud.Read<PersonModel>("Users", new Guid("7920d1c5-cc40-4e09-84b0-5b7d9c9b829b"));
            var rStr = JsonSerializer.Serialize(rec);
            Console.WriteLine(rStr);
            Console.WriteLine("==========================================================");

            // Console.WriteLine("message");
            Console.ReadKey();
        }
    }
}
