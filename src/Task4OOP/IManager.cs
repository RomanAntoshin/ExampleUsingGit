using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    interface IManager: IConsultant
    {
        //string View(int ind);
        void AddClient(Client client);
        void ChangeName(int ind, string name);
        void ChangeSurname(int ind, string surname);
        void ChangePatronymic(int ind, string patronymic);
        void ChangeSeriesPasport(int ind, string series);
        void ChangeNumberPasport(int ind, string number);
    }
}
