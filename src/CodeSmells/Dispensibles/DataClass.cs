// Sometimes data and behavior should be separate? Strategy, Visitor patterns, FP...
// Also known as an "Anemic Data Model": https://martinfowler.com/bliki/AnemicDomainModel.html
// Everybody has similar concerns, state (complexity) is bad m'kay, encapsulation!

namespace CodeSmells
{
    // Only public properties with getters and setterns
    public class DataClass
    {
        public string PropertyA { get; set; }
        public string PropertyB { get; set; }

        public override string ToString()
        {
            return $"A: {PropertyA}, B: {PropertyB}";
        }
    }

    // Is this the best way?
    // Example of a fluent interface https://en.wikipedia.org/wiki/Fluent_interface (LINQ does this)
    // immutable-ish, less surface area
    public class BetterishDataClass
    {
        // Could also have private "backing" vars here as an approach
        public string PropertyA { get; private set; }
        public string PropertyB { get; private set; }

        public BetterishDataClass(string propA, string propB)
        {
            PropertyA = propA;
            PropertyB = propB;
        }

        public BetterishDataClass AddStuffToPropA(string stuff)
        {
            PropertyA += stuff;
            return this;
        }

        public BetterishDataClass AddStuffToPropB(string stuff)
        {
            PropertyB += stuff;
            return this;
        }

        public override string ToString()
        {
            return $"A: {PropertyA}, B: {PropertyB}";
        }
    }
}
