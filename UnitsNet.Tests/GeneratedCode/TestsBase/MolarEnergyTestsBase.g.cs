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
    /// Test of MolarEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MolarEnergyTestsBase : QuantityTestsBase
    {
        protected abstract decimal JoulesPerMoleInOneJoulePerMole { get; }
        protected abstract decimal KilojoulesPerMoleInOneJoulePerMole { get; }
        protected abstract decimal MegajoulesPerMoleInOneJoulePerMole { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual decimal JoulesPerMoleTolerance { get { return 1e-5; } }
        protected virtual decimal KilojoulesPerMoleTolerance { get { return 1e-5; } }
        protected virtual decimal MegajoulesPerMoleTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MolarEnergy((decimal)0.0, MolarEnergyUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new MolarEnergy();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MolarEnergyUnit.JoulePerMole, quantity.Unit);
        }


        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MolarEnergy(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new MolarEnergy(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (MolarEnergy) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void MolarEnergy_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new MolarEnergy(1, MolarEnergyUnit.JoulePerMole);

            QuantityInfo<MolarEnergyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(MolarEnergy.Zero, quantityInfo.Zero);
            Assert.Equal("MolarEnergy", quantityInfo.Name);
            Assert.Equal(QuantityType.MolarEnergy, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<MolarEnergyUnit>().Except(new[] {MolarEnergyUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void JoulePerMoleToMolarEnergyUnits()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, joulepermole.JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, joulepermole.KilojoulesPerMole, KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, joulepermole.MegajoulesPerMole, MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = MolarEnergy.From(1, MolarEnergyUnit.JoulePerMole);
            AssertEx.EqualTolerance(1, quantity00.JoulesPerMole, JoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.JoulePerMole, quantity00.Unit);

            var quantity01 = MolarEnergy.From(1, MolarEnergyUnit.KilojoulePerMole);
            AssertEx.EqualTolerance(1, quantity01.KilojoulesPerMole, KilojoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.KilojoulePerMole, quantity01.Unit);

            var quantity02 = MolarEnergy.From(1, MolarEnergyUnit.MegajoulePerMole);
            AssertEx.EqualTolerance(1, quantity02.MegajoulesPerMole, MegajoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.MegajoulePerMole, quantity02.Unit);

        }

        [Fact]
        public void As()
        {
            var joulepermole = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, joulepermole.As(MolarEnergyUnit.JoulePerMole), JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, joulepermole.As(MolarEnergyUnit.KilojoulePerMole), KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, joulepermole.As(MolarEnergyUnit.MegajoulePerMole), MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new MolarEnergy(value: 1, unit: MolarEnergy.BaseUnit);
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
            var joulepermole = MolarEnergy.FromJoulesPerMole(1);

            var joulepermoleQuantity = joulepermole.ToUnit(MolarEnergyUnit.JoulePerMole);
            AssertEx.EqualTolerance(JoulesPerMoleInOneJoulePerMole, (decimal)joulepermoleQuantity.Value, JoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.JoulePerMole, joulepermoleQuantity.Unit);

            var kilojoulepermoleQuantity = joulepermole.ToUnit(MolarEnergyUnit.KilojoulePerMole);
            AssertEx.EqualTolerance(KilojoulesPerMoleInOneJoulePerMole, (decimal)kilojoulepermoleQuantity.Value, KilojoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.KilojoulePerMole, kilojoulepermoleQuantity.Unit);

            var megajoulepermoleQuantity = joulepermole.ToUnit(MolarEnergyUnit.MegajoulePerMole);
            AssertEx.EqualTolerance(MegajoulesPerMoleInOneJoulePerMole, (decimal)megajoulepermoleQuantity.Value, MegajoulesPerMoleTolerance);
            Assert.Equal(MolarEnergyUnit.MegajoulePerMole, megajoulepermoleQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = MolarEnergy.FromJoulesPerMole(1).ToBaseUnit();
            Assert.Equal(MolarEnergy.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(1, MolarEnergy.FromJoulesPerMole(joulepermole.JoulesPerMole).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarEnergy.FromKilojoulesPerMole(joulepermole.KilojoulesPerMole).JoulesPerMole, KilojoulesPerMoleTolerance);
            AssertEx.EqualTolerance(1, MolarEnergy.FromMegajoulesPerMole(joulepermole.MegajoulesPerMole).JoulesPerMole, MegajoulesPerMoleTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MolarEnergy v = MolarEnergy.FromJoulesPerMole(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (MolarEnergy.FromJoulesPerMole(3)-v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, (MolarEnergy.FromJoulesPerMole(10)/5).JoulesPerMole, JoulesPerMoleTolerance);
            AssertEx.EqualTolerance(2, MolarEnergy.FromJoulesPerMole(10)/MolarEnergy.FromJoulesPerMole(5), JoulesPerMoleTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MolarEnergy oneJoulePerMole = MolarEnergy.FromJoulesPerMole(1);
            MolarEnergy twoJoulesPerMole = MolarEnergy.FromJoulesPerMole(2);

            Assert.True(oneJoulePerMole < twoJoulesPerMole);
            Assert.True(oneJoulePerMole <= twoJoulesPerMole);
            Assert.True(twoJoulesPerMole > oneJoulePerMole);
            Assert.True(twoJoulesPerMole >= oneJoulePerMole);

            Assert.False(oneJoulePerMole > twoJoulesPerMole);
            Assert.False(oneJoulePerMole >= twoJoulesPerMole);
            Assert.False(twoJoulesPerMole < oneJoulePerMole);
            Assert.False(twoJoulesPerMole <= oneJoulePerMole);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.Equal(0, joulepermole.CompareTo(joulepermole));
            Assert.True(joulepermole.CompareTo(MolarEnergy.Zero) > 0);
            Assert.True(MolarEnergy.Zero.CompareTo(joulepermole) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.Throws<ArgumentException>(() => joulepermole.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.Throws<ArgumentNullException>(() => joulepermole.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = MolarEnergy.FromJoulesPerMole(1);
            var b = MolarEnergy.FromJoulesPerMole(2);

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
            var a = MolarEnergy.FromJoulesPerMole(1);
            var b = MolarEnergy.FromJoulesPerMole(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = MolarEnergy.FromJoulesPerMole(1);
            object b = MolarEnergy.FromJoulesPerMole(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = MolarEnergy.FromJoulesPerMole(1);
            Assert.True(v.Equals(MolarEnergy.FromJoulesPerMole(1), JoulesPerMoleTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MolarEnergy.Zero, JoulesPerMoleTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = MolarEnergy.FromJoulesPerMole(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(MolarEnergy.FromJoulesPerMole(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.False(joulepermole.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MolarEnergy joulepermole = MolarEnergy.FromJoulesPerMole(1);
            Assert.False(joulepermole.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MolarEnergyUnit.Undefined, MolarEnergy.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MolarEnergyUnit)).Cast<MolarEnergyUnit>();
            foreach(var unit in units)
            {
                if(unit == MolarEnergyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MolarEnergy.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 J/mol", new MolarEnergy(1, MolarEnergyUnit.JoulePerMole).ToString());
                Assert.Equal("1 kJ/mol", new MolarEnergy(1, MolarEnergyUnit.KilojoulePerMole).ToString());
                Assert.Equal("1 MJ/mol", new MolarEnergy(1, MolarEnergyUnit.MegajoulePerMole).ToString());
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

            Assert.Equal("1 J/mol", new MolarEnergy(1, MolarEnergyUnit.JoulePerMole).ToString(swedishCulture));
            Assert.Equal("1 kJ/mol", new MolarEnergy(1, MolarEnergyUnit.KilojoulePerMole).ToString(swedishCulture));
            Assert.Equal("1 MJ/mol", new MolarEnergy(1, MolarEnergyUnit.MegajoulePerMole).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s1"));
                Assert.Equal("0.12 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s2"));
                Assert.Equal("0.123 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s3"));
                Assert.Equal("0.1235 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s4"));
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
            Assert.Equal("0.1 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s1", culture));
            Assert.Equal("0.12 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s2", culture));
            Assert.Equal("0.123 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s3", culture));
            Assert.Equal("0.1235 J/mol", new MolarEnergy(0.123456m, MolarEnergyUnit.JoulePerMole).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(MolarEnergy)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MolarEnergyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal(QuantityType.MolarEnergy, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal(MolarEnergy.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = MolarEnergy.FromJoulesPerMole(1.0);
            Assert.Equal(new {MolarEnergy.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(decimal value)
        {
            var quantity = MolarEnergy.FromJoulesPerMole(value);
            Assert.Equal(MolarEnergy.FromJoulesPerMole(-value), -quantity);
        }
    }
}
