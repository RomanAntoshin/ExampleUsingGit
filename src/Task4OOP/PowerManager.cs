using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class PowerManager: Power
    {
        public override void MakeRequest(Client client, Fields.Field field, TypesChanges.TypeChange typeChange, string newData)
        {
            client.MakeChanges(field, typeChange, Autors.Autor.Manager, newData);
        }
    }
}
