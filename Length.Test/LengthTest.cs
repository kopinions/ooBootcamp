using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Length.Test
{

    public class LengthTest
    {
        [Fact]
        public void should_get_a_legal_length()
        {
            var length = new Length(10.0, Unit.CentiMetre);
            Assert.Equal(10.0, length.Value);
            Assert.Equal(Unit.CentiMetre, length.Unit);
        }

        [Fact]
        public void should_equal_when_value_unit_same()
        {
            var length1 = new Length(100.0, Unit.CentiMetre);
            var length2 = new Length(100.0, Unit.CentiMetre);
            Assert.True(length1.Equals(length2));

            length1 = new Length(1.0, Unit.Metre);
            length2 = new Length(1.0, Unit.Metre);
            Assert.True(length1.Equals(length2));

            length1 = new Length(10.0, Unit.MilliMetre);
            length2 = new Length(10.0, Unit.MilliMetre);
            Assert.True(length1.Equals(length2));
        }

        [Fact]
        public void should_transmit_between_different_unit()
        {
            var tenMitre = new Length(10, Unit.Metre);
            var aThousandCentiMetre = new Length(1000, Unit.CentiMetre);
            Assert.Equal(aThousandCentiMetre, aThousandCentiMetre);
        }
    }
}
