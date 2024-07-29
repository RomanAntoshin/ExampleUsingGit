using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class PowerConsultant: Power
    {
        public override void MakeRequest(Client client, Fields.Field field, TypesChanges.TypeChange typeChange, string newData)
        {
            //throw new NotImplementedException();
            if(field==Fields.Field.PhoneNumber && newData!="")
            {
                client.MakeChanges(field, typeChange, Autors.Autor.Consultant, newData);
            }
        }
    }
}
