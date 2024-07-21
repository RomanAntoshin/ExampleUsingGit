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
            if(change=="1")
            {
                Console.WriteLine("Consultant");
            }
            else
            {
                Console.WriteLine("Manager");
            }
            Client pasha = new Client("Pavlov", "Pavel", "Pavlovich", "8 922 923 24 25", "1111", "222222");
            Manager consultant = new Manager(data);
            //Console.WriteLine(pasha.History.Count);
            consultant.AddClient(pasha);
            consultant.AddClient("Ave", "Ave", "Ave", "03", "8888", "000001");

            consultant.ChangePhoneNumber(1, "8 444 444 44 44");
            consultant.ChangePhoneNumber(0, "");
            consultant.ChangeName(0, "Серега");
            for (int i = 0; i < consultant.Length; i++)
            {
                Console.WriteLine(consultant.View(i));
            }
            /*Console.WriteLine(consultant.View(0));
            Console.WriteLine(consultant.View(1));*/
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                string str = JsonSerializer.Serialize(consultant.Clients);
                writer.Write(str);
                writer.Close();
            }

        }
    }
}
