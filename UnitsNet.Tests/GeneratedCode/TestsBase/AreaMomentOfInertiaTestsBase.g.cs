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
    /// Test of AreaMomentOfInertia.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AreaMomentOfInertiaTestsBase : QuantityTestsBase
    {
        protected abstract decimal CentimetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract decimal DecimetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract decimal FeetToTheFourthInOneMeterToTheFourth { get; }
        protected abstract decimal InchesToTheFourthInOneMeterToTheFourth { get; }
        protected abstract decimal MetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract decimal MillimetersToTheFourthInOneMeterToTheFourth { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual decimal CentimetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual decimal DecimetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual decimal FeetToTheFourthTolerance { get { return 1e-5; } }
        protected virtual decimal InchesToTheFourthTolerance { get { return 1e-5; } }
        protected virtual decimal MetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual decimal MillimetersToTheFourthTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaMomentOfInertia((decimal)0.0, AreaMomentOfInertiaUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new AreaMomentOfInertia();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AreaMomentOfInertiaUnit.MeterToTheFourth, quantity.Unit);
        }


        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new AreaMomentOfInertia(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new AreaMomentOfInertia(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (AreaMomentOfInertia) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void AreaMomentOfInertia_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MeterToTheFourth);

            QuantityInfo<AreaMomentOfInertiaUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(AreaMomentOfInertia.Zero, quantityInfo.Zero);
            Assert.Equal("AreaMomentOfInertia", quantityInfo.Name);
            Assert.Equal(QuantityType.AreaMomentOfInertia, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<AreaMomentOfInertiaUnit>().Except(new[] {AreaMomentOfInertiaUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void MeterToTheFourthToAreaMomentOfInertiaUnits()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(CentimetersToTheFourthInOneMeterToTheFourth, metertothefourth.CentimetersToTheFourth, CentimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(DecimetersToTheFourthInOneMeterToTheFourth, metertothefourth.DecimetersToTheFourth, DecimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(FeetToTheFourthInOneMeterToTheFourth, metertothefourth.FeetToTheFourth, FeetToTheFourthTolerance);
            AssertEx.EqualTolerance(InchesToTheFourthInOneMeterToTheFourth, metertothefourth.InchesToTheFourth, InchesToTheFourthTolerance);
            AssertEx.EqualTolerance(MetersToTheFourthInOneMeterToTheFourth, metertothefourth.MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(MillimetersToTheFourthInOneMeterToTheFourth, metertothefourth.MillimetersToTheFourth, MillimetersToTheFourthTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.CentimeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity00.CentimetersToTheFourth, CentimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.CentimeterToTheFourth, quantity00.Unit);

            var quantity01 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.DecimeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity01.DecimetersToTheFourth, DecimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.DecimeterToTheFourth, quantity01.Unit);

            var quantity02 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.FootToTheFourth);
            AssertEx.EqualTolerance(1, quantity02.FeetToTheFourth, FeetToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.FootToTheFourth, quantity02.Unit);

            var quantity03 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.InchToTheFourth);
            AssertEx.EqualTolerance(1, quantity03.InchesToTheFourth, InchesToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.InchToTheFourth, quantity03.Unit);

            var quantity04 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.MeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity04.MetersToTheFourth, MetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MeterToTheFourth, quantity04.Unit);

            var quantity05 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.MillimeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity05.MillimetersToTheFourth, MillimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MillimeterToTheFourth, quantity05.Unit);

        }

        [Fact]
        public void As()
        {
            var metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(CentimetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.CentimeterToTheFourth), CentimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(DecimetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.DecimeterToTheFourth), DecimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(FeetToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.FootToTheFourth), FeetToTheFourthTolerance);
            AssertEx.EqualTolerance(InchesToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.InchToTheFourth), InchesToTheFourthTolerance);
            AssertEx.EqualTolerance(MetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.MeterToTheFourth), MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(MillimetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.MillimeterToTheFourth), MillimetersToTheFourthTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new AreaMomentOfInertia(value: 1, unit: AreaMomentOfInertia.BaseUnit);
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
            var metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);

            var centimetertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.CentimeterToTheFourth);
            AssertEx.EqualTolerance(CentimetersToTheFourthInOneMeterToTheFourth, (decimal)centimetertothefourthQuantity.Value, CentimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.CentimeterToTheFourth, centimetertothefourthQuantity.Unit);

            var decimetertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.DecimeterToTheFourth);
            AssertEx.EqualTolerance(DecimetersToTheFourthInOneMeterToTheFourth, (decimal)decimetertothefourthQuantity.Value, DecimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.DecimeterToTheFourth, decimetertothefourthQuantity.Unit);

            var foottothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.FootToTheFourth);
            AssertEx.EqualTolerance(FeetToTheFourthInOneMeterToTheFourth, (decimal)foottothefourthQuantity.Value, FeetToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.FootToTheFourth, foottothefourthQuantity.Unit);

            var inchtothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.InchToTheFourth);
            AssertEx.EqualTolerance(InchesToTheFourthInOneMeterToTheFourth, (decimal)inchtothefourthQuantity.Value, InchesToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.InchToTheFourth, inchtothefourthQuantity.Unit);

            var metertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.MeterToTheFourth);
            AssertEx.EqualTolerance(MetersToTheFourthInOneMeterToTheFourth, (decimal)metertothefourthQuantity.Value, MetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MeterToTheFourth, metertothefourthQuantity.Unit);

            var millimetertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.MillimeterToTheFourth);
            AssertEx.EqualTolerance(MillimetersToTheFourthInOneMeterToTheFourth, (decimal)millimetertothefourthQuantity.Value, MillimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MillimeterToTheFourth, millimetertothefourthQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = AreaMomentOfInertia.FromMetersToTheFourth(1).ToBaseUnit();
            Assert.Equal(AreaMomentOfInertia.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromCentimetersToTheFourth(metertothefourth.CentimetersToTheFourth).MetersToTheFourth, CentimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromDecimetersToTheFourth(metertothefourth.DecimetersToTheFourth).MetersToTheFourth, DecimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromFeetToTheFourth(metertothefourth.FeetToTheFourth).MetersToTheFourth, FeetToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromInchesToTheFourth(metertothefourth.InchesToTheFourth).MetersToTheFourth, InchesToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromMetersToTheFourth(metertothefourth.MetersToTheFourth).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromMillimetersToTheFourth(metertothefourth.MillimetersToTheFourth).MetersToTheFourth, MillimetersToTheFourthTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            AreaMomentOfInertia v = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(-1, -v.MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, (AreaMomentOfInertia.FromMetersToTheFourth(3)-v).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, (v + v).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(10, (v*10).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(10, (10*v).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, (AreaMomentOfInertia.FromMetersToTheFourth(10)/5).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, AreaMomentOfInertia.FromMetersToTheFourth(10)/AreaMomentOfInertia.FromMetersToTheFourth(5), MetersToTheFourthTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            AreaMomentOfInertia oneMeterToTheFourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AreaMomentOfInertia twoMetersToTheFourth = AreaMomentOfInertia.FromMetersToTheFourth(2);

            Assert.True(oneMeterToTheFourth < twoMetersToTheFourth);
            Assert.True(oneMeterToTheFourth <= twoMetersToTheFourth);
            Assert.True(twoMetersToTheFourth > oneMeterToTheFourth);
            Assert.True(twoMetersToTheFourth >= oneMeterToTheFourth);

            Assert.False(oneMeterToTheFourth > twoMetersToTheFourth);
            Assert.False(oneMeterToTheFourth >= twoMetersToTheFourth);
            Assert.False(twoMetersToTheFourth < oneMeterToTheFourth);
            Assert.False(twoMetersToTheFourth <= oneMeterToTheFourth);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.Equal(0, metertothefourth.CompareTo(metertothefourth));
            Assert.True(metertothefourth.CompareTo(AreaMomentOfInertia.Zero) > 0);
            Assert.True(AreaMomentOfInertia.Zero.CompareTo(metertothefourth) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.Throws<ArgumentException>(() => metertothefourth.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.Throws<ArgumentNullException>(() => metertothefourth.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = AreaMomentOfInertia.FromMetersToTheFourth(1);
            var b = AreaMomentOfInertia.FromMetersToTheFourth(2);

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
            var a = AreaMomentOfInertia.FromMetersToTheFourth(1);
            var b = AreaMomentOfInertia.FromMetersToTheFourth(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = AreaMomentOfInertia.FromMetersToTheFourth(1);
            object b = AreaMomentOfInertia.FromMetersToTheFourth(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.True(v.Equals(AreaMomentOfInertia.FromMetersToTheFourth(1), MetersToTheFourthTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AreaMomentOfInertia.Zero, MetersToTheFourthTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(AreaMomentOfInertia.FromMetersToTheFourth(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.False(metertothefourth.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.False(metertothefourth.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AreaMomentOfInertiaUnit.Undefined, AreaMomentOfInertia.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AreaMomentOfInertiaUnit)).Cast<AreaMomentOfInertiaUnit>();
            foreach(var unit in units)
            {
                if(unit == AreaMomentOfInertiaUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AreaMomentOfInertia.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.CentimeterToTheFourth).ToString());
                Assert.Equal("1 dm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.DecimeterToTheFourth).ToString());
                Assert.Equal("1 ft⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.FootToTheFourth).ToString());
                Assert.Equal("1 in⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.InchToTheFourth).ToString());
                Assert.Equal("1 m⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString());
                Assert.Equal("1 mm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MillimeterToTheFourth).ToString());
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

            Assert.Equal("1 cm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.CentimeterToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 dm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.DecimeterToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 ft⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.FootToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 in⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.InchToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 m⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 mm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MillimeterToTheFourth).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s1"));
                Assert.Equal("0.12 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s2"));
                Assert.Equal("0.123 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s3"));
                Assert.Equal("0.1235 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s4"));
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
            Assert.Equal("0.1 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s1", culture));
            Assert.Equal("0.12 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s2", culture));
            Assert.Equal("0.123 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s3", culture));
            Assert.Equal("0.1235 m⁴", new AreaMomentOfInertia(0.123456m, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(AreaMomentOfInertia)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(AreaMomentOfInertiaUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal(QuantityType.AreaMomentOfInertia, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal(AreaMomentOfInertia.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(1.0);
            Assert.Equal(new {AreaMomentOfInertia.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(decimal value)
        {
            var quantity = AreaMomentOfInertia.FromMetersToTheFourth(value);
            Assert.Equal(AreaMomentOfInertia.FromMetersToTheFourth(-value), -quantity);
        }
    }
}
