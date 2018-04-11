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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
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
    public abstract partial class AreaMomentOfInertiaTestsBase
    {
        protected abstract double CentimetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double DecimetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double FeetToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double InchesToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double MetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double MillimetersToTheFourthInOneMeterToTheFourth { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double DecimetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double FeetToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double InchesToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double MetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double MillimetersToTheFourthTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

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
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.CentimeterToTheFourth).CentimetersToTheFourth, CentimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.DecimeterToTheFourth).DecimetersToTheFourth, DecimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.FootToTheFourth).FeetToTheFourth, FeetToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.InchToTheFourth).InchesToTheFourth, InchesToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.MeterToTheFourth).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.MillimeterToTheFourth).MillimetersToTheFourth, MillimetersToTheFourthTolerance);
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
            AreaMomentOfInertia a = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AreaMomentOfInertia b = AreaMomentOfInertia.FromMetersToTheFourth(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            AreaMomentOfInertia v = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.True(v.Equals(AreaMomentOfInertia.FromMetersToTheFourth(1), AreaMomentOfInertia.FromMetersToTheFourth(MetersToTheFourthTolerance)));
            Assert.False(v.Equals(AreaMomentOfInertia.Zero, AreaMomentOfInertia.FromMetersToTheFourth(MetersToTheFourthTolerance)));
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
    }
}
