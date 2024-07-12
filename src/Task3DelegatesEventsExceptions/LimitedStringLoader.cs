using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3DelegatesEventsExceptions
{
    class LimitedStringLoader
    {
        private string prohibited;
        private string erroneus;
        private int proLimit;
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
                this.proLimit = proLimit;
            }
            catch(InconsistentLimits e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        class InconsistentLimits: Exception
        {
            public InconsistentLimits(string message): base(message) { }
        }
    }
}
