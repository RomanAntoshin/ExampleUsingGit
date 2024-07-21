using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class Manager: Consultant
    {
        public Manager(Client client) : base(client) { }
        public Manager(IList<Client> clients) : base(clients) { }
        public override string View(int ind)
        {
            return clients[ind].Surname + "\n" + clients[ind].Name + "\n" + clients[ind].Patronymic + "\n" + clients[ind].PhoneNumber + "\n" + clients[ind].SeriesPasport + "\n" + 
                clients[ind].NumberPasport + "\n";
        }
        public void AddClient(string surname, string name, string patronymic, string phoneNumber, string seriesPasport, string numberPasport)
        {
            this.clients.Add(new Client(surname, name, patronymic, phoneNumber, seriesPasport, numberPasport));
        }
        public void AddClient(Client client)
        {
            this.clients.Add(client);
            client.History.Add(new History(DateTime.Now, "All", "Add", "Manager"));
        }
        public void ChangeName(int ind, string name)
        {
            clients[ind].Name = name;
        }
        public void ChangeSurname(int ind, string surname)
        {
            clients[ind].Surname = surname;
        }
        public void ChangePatronymic(int ind, string patronymic)
        {
            clients[ind].Patronymic = patronymic;
        }
        public void ChangeSeriesPasport(int ind, string series)
        {
            clients[ind].SeriesPasport = series;
        }
        public void ChangeNumberPasport(int ind, string number)
        {
            clients[ind].NumberPasport = number;
        }
    }
}
