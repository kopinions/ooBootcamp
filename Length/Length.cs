using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOBootcamp
{
    public struct Length
    {
        public Length(double value, Unit unit) : this()
        {
            Unit = unit;
            Value = value;
        }

        public double Value { get; private set; }

        public Unit Unit { get; private set; }

        public bool Equals(Length length)
        {
            return Value.Equals(length.Value) && Unit.ToBase().Equals(length.Unit.ToBase());
        }

        public static bool operator ==(Length length1, Length length2)
        {
            return length1 != null && length1.Equals(length2);
        }

        public static bool operator !=(Length length1, Length length2)
        {
            return !(length1 == length2);
        }

        public static bool operator >(Length length1, Length length2)
        {
            throw new NotImplementedException();
        }

        public static bool operator <(Length length1, Length length2)
        {
            throw new NotImplementedException();
        }
    }

    public enum Unit
    {
        MilliMetre,
        CentiMetre,
        Metre
    }

    internal static class UnitExtensions
    {
        private static readonly Dictionary<Unit, double> rateMap = new Dictionary<Unit, double>()
            {
                { Unit.MilliMetre, 1 },
                { Unit.CentiMetre, 100 },
                { Unit.Metre, 1000 }
            };

        public static double ToBase(this Unit unit)
        {
            return rateMap[unit];
        }
    }
}
