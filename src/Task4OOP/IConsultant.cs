﻿using System.Collections.Generic;

namespace Task4OOP
{
    interface IConsultant
    {
        public int Length { get; }
        public IList<Client> Clients { get; }
        string View(int ind);
        void ChangeData(int ind, Fields.Field field, string newData);
        //void ChangePhoneNumber(int ind, string phoneNumber);
        //void WriteChange(int ind, string changes);
    }
}
