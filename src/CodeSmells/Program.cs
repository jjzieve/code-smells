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
            // var primitiveEmployee
        }
    }
}
