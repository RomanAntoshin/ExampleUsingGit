using System.Collections.Generic;

namespace Task4OOP
{
    class Consultant
    {
        private IList<Client> clients;
        public int Length { get { return clients.Count; } }
        public IList<Client> Clients { get { return clients; } }
        public Consultant(Client client)
        {
            this.clients = new Client[] { client };
        }
        public Consultant(IList<Client> clients) => this.clients = clients;
        public string View(int ind)
        {
            return clients[ind].Surname + "\n" + clients[ind].Name + "\n" + clients[ind].Patronymic + "\n" + clients[ind].PhoneNumber + "\n" + "****" + "\n" + "******" + "\n";
        }
        public void ChangePhoneNumber(int ind, string phoneNumber)
        {
            if (phoneNumber != "")
            {
                clients[ind].PhoneNumber = phoneNumber;
            }
        }
    }
}
