using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task3DelegatesEventsExceptions
{
    class LimitedStringLoader
    {
        private string prohibited;
        private string erroneus;
        private int proLimit;
        private List<string> data;
        public LimitedStringLoader(string prohibited, string erroneus, int proLimit)
        {
            var inter = prohibited.Intersect(erroneus);
            if (inter.Any())
            {
                throw new InconsistentLimits(string.Join(", ", inter));
            }
            this.erroneus = erroneus;
            this.prohibited = prohibited;
            if (proLimit < 0)
            {
                this.proLimit = 0;
            }
            else
            {
                this.proLimit = proLimit;
            }
        }
        public List<string> Data
        {
            get
            {
                if (data == null)
                {
                    throw new DataNotLoaded();
                }
                return data;
            }
        }
        public void Load(string filename)
        {
            try
            {
                using (var reader = new StreamReader(filename))
                {
                    try
                    {
                        data = new List<string>();
                        int defect = 0;
                        int i = 0;
                        while (!reader.EndOfStream)
                        {
                            string buf = reader.ReadLine();
                            if (!(buf[0] >= 'A' && buf[0] <= 'Z'))
                            {
                                data.Clear();
                                throw new IncorrectString(i);
                            }
                            if (erroneus.Contains(buf[0]))
                            {
                                data.Clear();
                                throw new WrongStartingSymbol(i, buf[0]);
                            }
                            if (prohibited.Contains(buf[0]))
                            {
                                defect++;
                                if (defect > proLimit)
                                {
                                    data.Clear();
                                    throw new TooManyProhibitedLines();
                                }
                            }
                            else
                            {
                                data.Add(buf);
                            }
                            i++;
                        }
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                throw;
            }
        }
        class InconsistentLimits : Exception
        {
            public InconsistentLimits(string message) : base("Uncorrect limits: " + message) { }
        }
        class IncorrectString : Exception
        {
            private readonly int number;
            public int Number { get { return number; } }
            public IncorrectString(int number) : base("Incorrect string: " + number.ToString())
            {
                this.number = number;
            }
        }
        class WrongStartingSymbol : Exception
        {
            private readonly char symbol;
            private readonly int number;
            public WrongStartingSymbol(int number, char symbol) : base("WrongStartingSymbol at line " + number.ToString() + ": " + symbol.ToString())
            {
                this.symbol = symbol;
                this.number = number;
            }

        }
        class TooManyProhibitedLines : Exception
        {
            public TooManyProhibitedLines() : base("TooManyProhibitedLines") { }
        }
        class DataNotLoaded : Exception
        {
            public DataNotLoaded() : base("DataNotLoaded") { }
        }
    }
}
