using System;

namespace CodeSmells
{
    public class PrimitiveEmployee
    {
        public string ZipCode { get; set; } // woops, added set on accident!
        public decimal Salary { get; } // should this be domain modeled?

        public PrimitiveEmployee(string zipCode, decimal salary)
        {
            Console.WriteLine("Employee regex validation for XXXXX or XXXXX-XXXX format");
            ZipCode = zipCode;
            Salary = salary;
        }
    }

    
    public class ZipCode
    {
        private readonly string _value;

        public ZipCode(string value)
        {
            Console.WriteLine("ZipCode regex validation for XXXXX or XXXXX-XXXX format");
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return _value;
        }
    }

    public class SophisticatedEmployee
    {
        public ZipCode ZipCode { get; set; } // woops, added set on accident!
        public decimal Salary { get; } // should this be domain modeled?

        public SophisticatedEmployee(ZipCode zipCode, decimal salary)
        {
            ZipCode = zipCode;
            Salary = salary;
        }
    }
}
