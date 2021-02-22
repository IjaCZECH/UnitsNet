﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricCurrentGradient.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentGradientTestsBase : QuantityTestsBase
    {
        protected abstract decimal AmperesPerSecondInOneAmperePerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual decimal AmperesPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricCurrentGradient((decimal)0.0, ElectricCurrentGradientUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricCurrentGradient();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricCurrentGradientUnit.AmperePerSecond, quantity.Unit);
        }


        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricCurrentGradient(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricCurrentGradient(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricCurrentGradient) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricCurrentGradient_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricCurrentGradient(1, ElectricCurrentGradientUnit.AmperePerSecond);

            QuantityInfo<ElectricCurrentGradientUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricCurrentGradient.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricCurrentGradient", quantityInfo.Name);
            Assert.Equal(QuantityType.ElectricCurrentGradient, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ElectricCurrentGradientUnit>().Except(new[] {ElectricCurrentGradientUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void AmperePerSecondToElectricCurrentGradientUnits()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(AmperesPerSecondInOneAmperePerSecond, amperepersecond.AmperesPerSecond, AmperesPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricCurrentGradient.From(1, ElectricCurrentGradientUnit.AmperePerSecond);
            AssertEx.EqualTolerance(1, quantity00.AmperesPerSecond, AmperesPerSecondTolerance);
            Assert.Equal(ElectricCurrentGradientUnit.AmperePerSecond, quantity00.Unit);

        }

        [Fact]
        public void As()
        {
            var amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(AmperesPerSecondInOneAmperePerSecond, amperepersecond.As(ElectricCurrentGradientUnit.AmperePerSecond), AmperesPerSecondTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricCurrentGradient(value: 1, unit: ElectricCurrentGradient.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (decimal) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);

            var amperepersecondQuantity = amperepersecond.ToUnit(ElectricCurrentGradientUnit.AmperePerSecond);
            AssertEx.EqualTolerance(AmperesPerSecondInOneAmperePerSecond, (decimal)amperepersecondQuantity.Value, AmperesPerSecondTolerance);
            Assert.Equal(ElectricCurrentGradientUnit.AmperePerSecond, amperepersecondQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = ElectricCurrentGradient.FromAmperesPerSecond(1).ToBaseUnit();
            Assert.Equal(ElectricCurrentGradient.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(1, ElectricCurrentGradient.FromAmperesPerSecond(amperepersecond.AmperesPerSecond).AmperesPerSecond, AmperesPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrentGradient v = ElectricCurrentGradient.FromAmperesPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentGradient.FromAmperesPerSecond(3)-v).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrentGradient.FromAmperesPerSecond(10)/5).AmperesPerSecond, AmperesPerSecondTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrentGradient.FromAmperesPerSecond(10)/ElectricCurrentGradient.FromAmperesPerSecond(5), AmperesPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrentGradient oneAmperePerSecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            ElectricCurrentGradient twoAmperesPerSecond = ElectricCurrentGradient.FromAmperesPerSecond(2);

            Assert.True(oneAmperePerSecond < twoAmperesPerSecond);
            Assert.True(oneAmperePerSecond <= twoAmperesPerSecond);
            Assert.True(twoAmperesPerSecond > oneAmperePerSecond);
            Assert.True(twoAmperesPerSecond >= oneAmperePerSecond);

            Assert.False(oneAmperePerSecond > twoAmperesPerSecond);
            Assert.False(oneAmperePerSecond >= twoAmperesPerSecond);
            Assert.False(twoAmperesPerSecond < oneAmperePerSecond);
            Assert.False(twoAmperesPerSecond <= oneAmperePerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.Equal(0, amperepersecond.CompareTo(amperepersecond));
            Assert.True(amperepersecond.CompareTo(ElectricCurrentGradient.Zero) > 0);
            Assert.True(ElectricCurrentGradient.Zero.CompareTo(amperepersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.Throws<ArgumentException>(() => amperepersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => amperepersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricCurrentGradient.FromAmperesPerSecond(1);
            var b = ElectricCurrentGradient.FromAmperesPerSecond(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = ElectricCurrentGradient.FromAmperesPerSecond(1);
            var b = ElectricCurrentGradient.FromAmperesPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ElectricCurrentGradient.FromAmperesPerSecond(1);
            object b = ElectricCurrentGradient.FromAmperesPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.True(v.Equals(ElectricCurrentGradient.FromAmperesPerSecond(1), AmperesPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricCurrentGradient.Zero, AmperesPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricCurrentGradient.FromAmperesPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.False(amperepersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrentGradient amperepersecond = ElectricCurrentGradient.FromAmperesPerSecond(1);
            Assert.False(amperepersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricCurrentGradientUnit.Undefined, ElectricCurrentGradient.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricCurrentGradientUnit)).Cast<ElectricCurrentGradientUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricCurrentGradientUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricCurrentGradient.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 A/s", new ElectricCurrentGradient(1, ElectricCurrentGradientUnit.AmperePerSecond).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 A/s", new ElectricCurrentGradient(1, ElectricCurrentGradientUnit.AmperePerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s1"));
                Assert.Equal("0.12 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s2"));
                Assert.Equal("0.123 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s3"));
                Assert.Equal("0.1235 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s1", culture));
            Assert.Equal("0.12 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s2", culture));
            Assert.Equal("0.123 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 A/s", new ElectricCurrentGradient(0.123456m, ElectricCurrentGradientUnit.AmperePerSecond).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricCurrentGradient)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricCurrentGradientUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal(QuantityType.ElectricCurrentGradient, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal(ElectricCurrentGradient.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(1.0);
            Assert.Equal(new {ElectricCurrentGradient.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(decimal value)
        {
            var quantity = ElectricCurrentGradient.FromAmperesPerSecond(value);
            Assert.Equal(ElectricCurrentGradient.FromAmperesPerSecond(-value), -quantity);
        }
    }
}
