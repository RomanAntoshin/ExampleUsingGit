using System;
using System.Collections.Generic;

namespace Task4OOP
{
    class Manager : Consultant, IManager
    {
        public Manager(Client client) : base(client) { }
        public Manager(IList<Client> clients) : base(clients) { }
        public override string View(int ind)
        {
            return clients[ind].PrintAll();
        }
        public void AddClient(Client client)
        {
            this.clients.Add(client);
            client.History.Add(new History(DateTime.Now, "All", "Add", "Manager"));
        }
        public void ChangeName(int ind, string name)
        {
            clients[ind].Name = name;
            WriteChange(ind, "Name");
        }
        public void ChangeSurname(int ind, string surname)
        {
            clients[ind].Surname = surname;
            WriteChange(ind, "Surname");
        }
        public void ChangePatronymic(int ind, string patronymic)
        {
            clients[ind].Patronymic = patronymic;
            WriteChange(ind, "Patronymic");
        }
        public void ChangeSeriesPasport(int ind, string series)
        {
            clients[ind].SeriesPasport = series;
            WriteChange(ind, "SeriesPasport");
        }
        public void ChangeNumberPasport(int ind, string number)
        {
            clients[ind].NumberPasport = number;
            WriteChange(ind, "NumberPasport");
        }
    }
}
