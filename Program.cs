using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectMany
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoples = new List<People>() {
                new People() {
                    Name = "People1",
                    PhoneNumbers = new List<PhoneNumber>() {
                        new PhoneNumber() { Number = "123456789"} ,
                        new PhoneNumber() { Number = "123456789"},
                        new PhoneNumber() { Number = "123456789"}
                    }
                },
                new People() {
                    Name = "People2",
                    PhoneNumbers = new List<PhoneNumber>() {
                        new PhoneNumber() { Number = "123456789"} ,
                        new PhoneNumber() { Number = "123456789"},
                        new PhoneNumber() { Number = "123456789"}
                    }
                },
                new People() {
                    Name = "People3",
                    PhoneNumbers = new List<PhoneNumber>() {
                        new PhoneNumber() { Number = "123456789"} ,
                        new PhoneNumber() { Number = "123456789"},
                        new PhoneNumber() { Number = "123456789"}
                    }
                },
                new People() {
                    Name = "People4",
                    PhoneNumbers = new List<PhoneNumber>() {
                        new PhoneNumber() { Number = "123456789"} ,
                        new PhoneNumber() { Number = "123456789"},
                        new PhoneNumber() { Number = "123456789"}
                    }
                }
            };
            var result = peoples.Where(x => x.Name == "People3")
                                .Select(x => Tuple.Create( x.Name, string.Join(",", x.PhoneNumbers.Select(x => x.Number))))
                                .ToList();

          
            Console.WriteLine($"{result[0].Item1}-{result[0].Item2}");


        }

        public class People
        {
            public string Name { get; set; }
            public List<PhoneNumber> PhoneNumbers { get; set; }
        }
        public class PhoneNumber
        {
            public string Number { get; set; }
        }
    }
}
