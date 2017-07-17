using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("sister", new Dictionary<string, string>(){ 
                {"name", "Krista"},
                {"age", "42"}
            });

            myFamily.Add("brother", new Dictionary<string, string>(){ 
                {"name", "Bod"},
                {"age", "39"}
            });

            foreach (KeyValuePair<string, Dictionary<string, string>> fam in myFamily) 
            {
                Console.WriteLine($"{fam.Value["name"]} is my {fam.Key} and is {fam.Value["age"]} years old");
            }

        }
    }
}
