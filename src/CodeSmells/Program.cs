using System;

namespace CodeSmells
{
    class EvilDataClassClient
    {
        public EvilDataClassClient(DataClass dc)
        {
            dc.PropertyA = "I'm evil!";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var dc = new DataClass();
            // dc.PropertyA = "not evil";
            // var evil = new EvilDataClassClient(dc);
            // Console.WriteLine(dc);


            var betterDc = new BetterishDataClass("not evil", "I promise");
            // betterDc.PropertyA = "evil";
            var betterDc2 = betterDc
                .AddStuffToPropA(", jk kinda evil")
                .AddStuffToPropB(", I swear! ");

            Console.WriteLine($"Better dc : {betterDc}");
            var evilPropB = "ok, I lied";
            Console.WriteLine($"Better dc2: {betterDc2.AddStuffToPropB(evilPropB)}");
        }
    }
}
