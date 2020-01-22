using System;
using System.Text.RegularExpressions;

namespace CodeSmells
{
    public class PrimitiveEmployee
    {
        public string ZipCode { get; set; } // woops, added set on accident!

        // https://enterprisecraftsmanship.com/posts/functional-c-primitive-obsession/
        // public decimal Salary { get; }  // should all fields be be domain modeled?

        public PrimitiveEmployee(string zipCode)
        {
            if (!Regex.Match(zipCode, @"\d{5}([ \-]\d{4})?$").Success)
            {
                throw new ArgumentException($"Failed employee zip code regex validation, \"{zipCode}\" is not in XXXXX or XXXXX-XXXX format");
            }
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"PrimitiveEmployee(zip: {ZipCode})";
        }
    }

    
    public class ZipCode
    {
        private readonly string _value;

        public ZipCode(string value)
        {
            if (!Regex.Match(value, @"\d{5}([ \-]\d{4})?$").Success)
            {
                throw new ArgumentException($"Failed zip code regex validation, \"{value}\" is not in XXXXX or XXXXX-XXXX format");
            }
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

        public SophisticatedEmployee(ZipCode zipCode)
        {
            ZipCode = zipCode;
        }

        public override string ToString()
        {
            return $"SophisticatedEmployee(zip: {ZipCode})";
        }
    }
}
