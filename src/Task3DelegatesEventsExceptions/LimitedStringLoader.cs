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
            this.proLimit = proLimit < 0 ? 0 : proLimit;
        }
        public List<string> Data => data ?? throw new DataNotLoaded();
        public void Load(string filename)
        {
            using (var reader = new StreamReader(filename))
            {
                var buffer = new List<string>();
                int defect = 0;
                int i = 0;
                while (!reader.EndOfStream)
                {
                    string buf = reader.ReadLine();
                    if (!(buf[0] >= 'A' && buf[0] <= 'Z'))
                    {
                        throw new IncorrectString(i);
                    }
                    if (erroneus.Contains(buf[0]))
                    {
                        throw new WrongStartingSymbol(i, buf[0]);
                    }
                    if (prohibited.Contains(buf[0]))
                    {
                        defect++;
                        if (defect > proLimit)
                        {
                            throw new TooManyProhibitedLines();
                        }
                    }
                    else
                    {
                        buffer.Add(buf);
                    }
                    i++;
                }
                data = buffer;
            }
        }
    }
}
