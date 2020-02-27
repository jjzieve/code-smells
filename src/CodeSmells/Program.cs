using System;

namespace CodeSmells
{
    class Program
    {
        static void Main(string[] args)
        {
            /* DataClass Examples */
            // var dc = new DataClass();
            // dc.PropertyA = "not evil";
            // var evil = new EvilDataClassClient(dc);
            // Console.WriteLine(dc);

            // var betterDc = new BetterishDataClass("not evil", "I promise");
            // Console.WriteLine($"dc: {betterDc}");
            // // betterDc.PropertyA = "evil";
            // var betterDc2 = betterDc
            //     .AddStuffToPropA(", jk kinda evil")
            //     .AddStuffToPropB(", I swear! ");

            // Console.WriteLine($"Better dc : {betterDc}");
            // var evilPropB = "ok, I lied";
            // Console.WriteLine($"Better dc2: {betterDc2.AddStuffToPropB(evilPropB)}");

            /* PrimitiveObsession Examples */
            // try
            // {
                // var primitiveEmployee = new PrimitiveEmployee(zipCode: "blah");
                // var primitiveEmployee = new PrimitiveEmployee("92126");
                // Console.WriteLine(primitiveEmployee);
                // primitiveEmployee.ZipCode = "Not a zip code!";
                // Console.WriteLine(primitiveEmployee);

                // var zipCode = new ZipCode("blah");
                // var zipCode = new ZipCode("92126");
                // var sophisticatedEmployee = new SophisticatedEmployee(zipCode);
                // Console.WriteLine(sophisticatedEmployee);
                // // sophisticatedEmployee.ZipCode = "Not a zip code!";
                // // sophisticatedEmployee.ZipCode = new ZipCode("Not a zip code!");
                // sophisticatedEmployee.ZipCode = new ZipCode("92126-1234");
                // Console.WriteLine(sophisticatedEmployee);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e.Message);
            // }

            /* MessageChain Examples */
            var eng = new Department("Engineering", "Point-haired boss");
            var alice = new Employee(name: "Alice", department: eng);
            Console.WriteLine(alice.Department.Manager);

            var dilbert = new Employee("Dilbert", eng);
            // // pointy gets fired!
            eng.Manager = null;
            Console.WriteLine(dilbert.Department.Manager);

            var wally = new BetterEmployee("Wally", eng);
            Console.WriteLine(wally.Manager);

        }
    }
}
