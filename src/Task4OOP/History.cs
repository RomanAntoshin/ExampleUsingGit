using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4OOP
{
    class History
    {
        private DateTime dateTime;
        private string dataChanged;
        private string type;
        private string autor;
        public DateTime DateTime { get; }
        public string DataChanged { get; }
        public string Type { get; }
        public string Autor { get; }
        public History(DateTime dateTime, string dataChanged, string type, string autor)
        {
            DateTime = dateTime;
            DataChanged = dataChanged;
            Type = type;
            Autor = autor;
        }
        public void Print()
        {
            Console.WriteLine(DateTime);
            Console.WriteLine(DataChanged);
            Console.WriteLine(Type);
            Console.WriteLine(Autor);
        }
    }
}
