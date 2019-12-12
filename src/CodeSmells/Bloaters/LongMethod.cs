using System;

namespace CodeSmells 
{
    public class LongMethod
    {
        public void Blah()
        {
            // write 5 blahs
            Console.WriteLine("blah");
            Console.WriteLine("blah");
            Console.WriteLine("blah");
            Console.WriteLine("blah");
            Console.WriteLine("blah");
            Console.WriteLine("blah");

            // write 5 blahs again
            Write5Blahs();

        }
        private void Write5Blahs()
        {
            Console.WriteLine("blah");
            Console.WriteLine("blah");
            Console.WriteLine("blah");
            Console.WriteLine("blah");
            Console.WriteLine("blah");
        }
    }
}