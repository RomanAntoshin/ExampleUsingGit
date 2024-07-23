namespace Task4OOP
{
    interface IManager : IConsultant
    {
        void AddClient(Client client);
        //void ChangeData(int ind, string field, string newData);
        /*void ChangeName(int ind, string name);
        void ChangeSurname(int ind, string surname);
        void ChangePatronymic(int ind, string patronymic);
        void ChangeSeriesPasport(int ind, string series);
        void ChangeNumberPasport(int ind, string number);*/
    }
}
