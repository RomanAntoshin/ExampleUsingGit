using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    interface IConsultant
    {
        public int Length { get; }
        public IList<Client> Clients { get; }
        string View(int ind);
        void ChangePhoneNumber(int ind, string phoneNumber);
        void WriteChange(int ind, string changes);
    }
}
