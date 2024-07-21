using System;
using System.Collections.Generic;

namespace Task4OOP
{
    class Consultant
    {
        protected IList<Client> clients;
        public int Length { get { return clients.Count; } }
        public IList<Client> Clients { get { return clients; } }
        public Consultant(Client client)
        {
             this.clients = new List<Client> { client };
            //clients.Add(client);
        }
        public Consultant(IList<Client> clients) => this.clients = clients;
        public virtual string View(int ind)
        {
            //return clients[ind].Surname + "\n" + clients[ind].Name + "\n" + clients[ind].Patronymic + "\n" + clients[ind].PhoneNumber + "\n" + "****" + "\n" + "******" + "\n";
            return clients[ind].PrintSecret();
        }
        public void ChangePhoneNumber(int ind, string phoneNumber)
        {
            if (phoneNumber != "")
            {
                clients[ind].PhoneNumber = phoneNumber;
                WriteChange(ind, phoneNumber);
            }
        }
        public void WriteChange(int ind, string changes)
        {
            clients[ind].History.Add(new History(DateTime.Now, changes, "Update", this.GetType().ToString()));
        }
    }
}
