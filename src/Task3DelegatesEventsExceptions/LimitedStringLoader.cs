using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
            try
            {
                var inter = prohibited.Intersect(erroneus);
                if (inter.Any())
                {
                    throw new InconsistentLimits("Uncorrect limits: "+string.Join(", ", inter));
                }
                //if(inter.)
                /*if (prohibited.Any(s => erroneus.Contains(s)))
                {
                    throw new Exception(s);
                }*/
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
            catch(InconsistentLimits e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        public List<string> Data 
        { 
            get 
            {
                try
                {
                    if(data==null)
                    {
                        throw new DataNotLoaded("DataNotLoaded");
                    }
                    return data;
                }
                catch(DataNotLoaded e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
        public void Load(string filename)
        {
            try
            {
                using (var reader = new StreamReader(filename))
                {
                    //Console.WriteLine(reader.ReadLine()[0]);
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
                                throw new IncorrectString("IncorrectString in string", i);
                            }
                            if(erroneus.Contains(buf[0]))
                            {
                                data.Clear();
                                throw new WrongStartingSymbol("WrongStartSymbol in string ", i, buf[0]);
                            }
                            if(prohibited.Contains(buf[0]))
                            {
                                defect++;
                                if(defect>proLimit)
                                {
                                    data.Clear();
                                    throw new TooManyProhibitedLines("TooManyProhibitedLines");
                                }
                            }
                            else
                            {
                                data.Add(buf);
                            }
                            //data.Add(buf);
                            i++;
                        }
                    }
                    catch (WrongStartingSymbol e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    catch (IncorrectString e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    catch(TooManyProhibitedLines e)
                    {
                        Console.WriteLine(e.Message);
                        throw;
                    }
                    finally
                    {
                        reader.Close();
                    }
                }
            }
            catch(System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        class InconsistentLimits: Exception
        {
            public InconsistentLimits(string message): base(message) { }
        }
        class IncorrectString: Exception
        {
            protected string message;
            protected readonly int number;
            public int Number { get { return number; } }
            new public string Message { get { return message; } /*set { message = value; }*/ }
            public IncorrectString(string message, int number): base(message)
            {
                this.number = number;
                this.message = base.Message + number.ToString();
                //this.message = message + ": " + number.ToString();
            }
        }
        class WrongStartingSymbol: IncorrectString
        {
            private char symbol;
            public WrongStartingSymbol(string message, int number, char symbol): base(message, number)
            {
                this.symbol = symbol;
                base.message = base.message + ": " + symbol.ToString();
                //base.Message=
            }
        }
        class TooManyProhibitedLines:Exception
        {
            public TooManyProhibitedLines(string message) : base(message) { }
        }
        class DataNotLoaded: Exception
        {
            public DataNotLoaded(string message) : base(message) { }
        }
    }
}
