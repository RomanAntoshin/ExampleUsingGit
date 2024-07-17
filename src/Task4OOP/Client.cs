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
        public string Surname { get; }
        public string Name { get; }
        public string Patronymic { get; }
        public string PhoneNumber { get; set; }
        public string SeriesPasport { get; }
        public string NumberPasport { get; }
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
