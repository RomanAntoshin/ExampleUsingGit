using System;
using System.Collections.Generic;

namespace Task4OOP
{
    class Client
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string SeriesPasport { get; set; }
        public string NumberPasport { get; set; }
        public List<History> History { get; set; }
        public Client(string surname, string name, string patronymic, string phoneNumber, string seriesPasport, string numberPasport)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            SeriesPasport = seriesPasport;
            NumberPasport = numberPasport;
            if (History == null)
            {
                History = new List<History>();
            }
        }
        public string PrintSecret()
        {
            return Surname + "\n" + Name + "\n" + Patronymic + "\n" + PhoneNumber + "\n" + "****" + "\n" + "******" + "\n";
        }
        public string PrintAll()
        {
            return Surname + "\n" + Name + "\n" + Patronymic + "\n" + PhoneNumber + "\n" + SeriesPasport + "\n" + NumberPasport + "\n";
        }
        public void MakeChanges(string field, string typechange, string autor, string newData)
        {
            switch (field)
            {
                case "Surname":
                    this.Surname = newData;
                    break;
                case "Name":
                    this.Name = newData;
                    break;
                case "Patronymic":
                    this.Patronymic = newData;
                    break;
                case "SeriesPasport":
                    this.SeriesPasport = newData;
                    break;
                case "NumberPasport":
                    this.NumberPasport = newData;
                    break;
                case "PhoneNumber":
                    this.PhoneNumber = newData;
                    break;                  
            }
            History.Add(new History(DateTime.Now, field, "Update", autor));
        }
    }
}
