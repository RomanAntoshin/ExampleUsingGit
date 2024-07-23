using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    abstract class Power
    {
        abstract public void MakeRequest(Client client, string field, string typeChange, string newData);
    }
}
