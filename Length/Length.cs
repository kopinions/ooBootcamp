﻿using System;

namespace OOBootcamp
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

        public bool Equals(Length length)
        {
            return Unit == length.Unit ? Value.Equals(length.Value) : Value.Equals(length.Value * Unit.ConvertTo(Unit));
        }


        public Length Convert(Unit unit)
        {
            return new Length(Value * Unit.ConvertTo(unit), unit);
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

    public class Unit
    {
        public double Rate { get; private set; }
        public readonly static Unit Metre = new Unit(1000);
        public readonly static Unit CentiMetre = new Unit(10);
        public readonly static Unit MilliMetre = new Unit(1);
        
        public Unit(double rate)
        {
            Rate = rate;
        }

        public double ConvertTo(Unit to)
        {
            return Rate/to.Rate;
        }

        public static double ConvertTo(Unit from, Unit to)
        {
            return from.Rate / to.Rate;
        }
    }

}

