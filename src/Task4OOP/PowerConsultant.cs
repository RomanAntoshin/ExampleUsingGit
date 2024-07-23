using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class PowerConsultant: Power
    {
        public override void MakeRequest(Client client, string field, string typeChange, string newData)
        {
            //throw new NotImplementedException();
            if(field=="PhoneNumber" && newData!="")
            {
                client.MakeChanges(field, typeChange, "Consultant", newData);
            }
        }
    }
}
