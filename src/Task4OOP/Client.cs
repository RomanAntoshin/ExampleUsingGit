namespace Task4OOP
{
    class Client
    {
        private string surname;
        private string name;
        private string patronymic;
        private string phoneNumber;
        private string seriesPasport;
        private string numberPasport;
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PhoneNumber { get; set; }
        public string SeriesPasport { get; set; }
        public string NumberPasport { get; set; }
        public Client(string surname, string name, string patronymic, string phoneNumber, string seriesPasport, string numberPasport)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            SeriesPasport = seriesPasport;
            NumberPasport = numberPasport;
        }

    }
}
