using System;
using System.Collections.Generic;

namespace Task4OOP
{
    class Consultant : IConsultant
    {
        protected IList<Client> clients;
        private Power power;
        public int Length { get { return clients.Count; } }
        public IList<Client> Clients { get { return clients; } }
        public Consultant(Client client, Power power)
        {
            this.clients = new List<Client> { client };
            this.power = power;
        }
        public Consultant(IList<Client> clients, Power power)
        {
            this.clients = clients;
            this.power = power;
        }
        public virtual string View(int ind)
        {
            return clients[ind].PrintSecret();
        }
        public void ChangePhoneNumber(int ind, string phoneNumber)
        {
            power.MakeRequest(clients[ind], "PhoneNumber", "Update", phoneNumber);
            /*if (phoneNumber != "")
            {
                clients[ind].PhoneNumber = phoneNumber;
                WriteChange(ind, "PhoneNumber");
            }*/
        }
        public void WriteChange(int ind, string changes)
        {
            clients[ind].History.Add(new History(DateTime.Now, changes, "Update", this.GetType().ToString()));
        }
    }
}
