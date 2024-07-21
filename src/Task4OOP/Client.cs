using System.Collections.Generic;

namespace Task4OOP
{
    class Client
    {
        //private string surname;
        /*private string name;
        private string patronymic;
        private string phoneNumber;
        private string seriesPasport;
        private string numberPasport;*/
        private List<History> history/* = new List<History>()*/;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string SeriesPasport { get; set; }
        public string NumberPasport { get; set; }
        public List<History> History { get { return history; } }
        public Client(string surname, string name, string patronymic, string phoneNumber, string seriesPasport, string numberPasport)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            SeriesPasport = seriesPasport;
            NumberPasport = numberPasport;
            if(this.history==null)
            {
                this.history = new List<History>();
            }
            //history.Add(new History(DateTime.Now, "All", "Add", "Manager"));
            //history = new List<History>();
        }
        public string PrintSecret()
        {
            return Surname + "\n" + Name + "\n" + Patronymic + "\n" + PhoneNumber + "\n" + "****" + "\n" + "******" + "\n";
        }
        public string PrintAll()
        {
            return Surname + "\n" + Name + "\n" + Patronymic + "\n" + PhoneNumber + "\n" + SeriesPasport + "\n" + NumberPasport + "\n";
        }
    }
}
