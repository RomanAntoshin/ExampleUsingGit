using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Task4OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> data;
            using (StreamReader reader = new StreamReader("Database.txt"))
            {
                data = JsonSerializer.Deserialize<List<Client>>(reader.ReadToEnd());
            }
            Consultant consultant = new Consultant(data);
            for (int i = 0; i < consultant.Length; i++)
            {
                Console.WriteLine(consultant.View(i));
            }
            consultant.ChangePhoneNumber(1, "8 922 994 77 88");
            consultant.ChangePhoneNumber(0, "");
            Console.WriteLine(consultant.View(0));
            Console.WriteLine(consultant.View(1));
        }
    }
}
