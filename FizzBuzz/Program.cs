using System.Collections.Generic;
using System;
using System.Text;

Dictionary<int, string> fizzBuzzMapping = new Dictionary<int, string>
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

for (int i = 1; i <= 100; i++)
{
    string output = "";

    foreach (KeyValuePair<int, string> entry in fizzBuzzMapping)
    {
        if (i % entry.Key == 0)
        {
            output += entry.Value;
        }
    }

    if (string.IsNullOrEmpty(output))
    {
        output = i.ToString();
    }

    Console.WriteLine(output);
}
