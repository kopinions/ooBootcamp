using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Length
{
    public class Length
    {
        

        public Length(double value, Unit unit)
        {
            Unit = unit;
            Value = value;
        }

        public double Value { get; private set; }

        public Unit Unit { get; private set; }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Length) obj);
        }

        protected bool Equals(Length length)
        {
            return Value.Equals(length.Value) && Unit == length.Unit;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Value.GetHashCode() * 397) ^ (int)Unit;
            }
        }

        public Length Convert(Unit unit)
        {
            if (this.Unit == unit)
            {
                return this;
            }
            else
            {
                if (unit == Unit.CentiMetre && this.Unit == Unit.Metre)
                {
                    var transmit = new Length(this.Value*100, unit);
                    return transmit;
                }
                return null;
            }
        }
    }

    public enum Unit
    {
        MilliMetre,
        CentiMetre,
        Metre
    }
}
