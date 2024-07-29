using System;

namespace Task3DelegatesEventsExceptions
{
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
