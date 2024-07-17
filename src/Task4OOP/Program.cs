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
            string path = AppContext.BaseDirectory;
            int index = path.IndexOf("bin", StringComparison.Ordinal);
            string projectPath = path.Substring(0, index);
            string filePath = Path.Combine(projectPath, "Database.txt");
            Console.WriteLine(filePath);
            using (StreamReader reader = new StreamReader(filePath))
            {
                data = JsonSerializer.Deserialize<List<Client>>(reader.ReadToEnd());
                reader.Close();
            }
            Consultant consultant = new Consultant(data);
            for (int i = 0; i < consultant.Length; i++)
            {
                Console.WriteLine(consultant.View(i));
            }
            consultant.ChangePhoneNumber(1, "8 444 444 44 44");
            consultant.ChangePhoneNumber(0, "");
            Console.WriteLine(consultant.View(0));
            Console.WriteLine(consultant.View(1));
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string str = JsonSerializer.Serialize(consultant.Clients);
                writer.Write(str);
                writer.Close();
            }

        }
    }
}
