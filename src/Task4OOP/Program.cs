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
            string change;
            do
            {
                Console.WriteLine("Выберите режим работы: 1 - консультант; 2 - менеджер");
                change = Console.ReadLine();
            }
            while (change != "1" & change != "2");
            if (change == "1")
            {
                Console.WriteLine("Consultant");
                IConsultant consultant = new Consultant(data);
                consultant.ChangePhoneNumber(1, "8 444 444 44 44");
                consultant.ChangePhoneNumber(0, "");
                WriteFile(consultant, filePath);
                for (int i = 0; i < consultant.Length; i++)
                {
                    Console.WriteLine(consultant.Clients[i].PrintSecret());
                }
            }
            else
            {
                Console.WriteLine("Manager");
                IManager manager = new Manager(data);
                manager.ChangeName(0, "Серега");
                manager.ChangePatronymic(1, "Ave");
                manager.ChangeName(1, "Second");
                //manager.AddClient(new Client("First", "Second", "Third", "8 912 913 14 15", "1112", "876543"));
                WriteFile(manager, filePath);
                for (int i = 0; i < manager.Length; i++)
                {
                    Console.WriteLine(manager.Clients[i].PrintAll());
                }
            }
        }
        static void WriteFile(IConsultant consultant, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string str = JsonSerializer.Serialize(consultant.Clients);
                writer.Write(str);
                writer.Close();
            }
        }
    }
}
