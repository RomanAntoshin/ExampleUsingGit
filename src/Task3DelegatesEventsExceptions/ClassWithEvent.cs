using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3DelegatesEventsExceptions
{
    class ClassWithEvent
    {
        public event Action<string> Notify;
        private string name;
        public ClassWithEvent(string name) => this.name = name;
        public void GenerateEvent() => Notify?.Invoke(name);
        public void AddHandler(Action<string> del) => Notify += del;

    }
}
