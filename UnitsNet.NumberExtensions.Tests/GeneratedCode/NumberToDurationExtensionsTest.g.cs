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

using UnitsNet.NumberExtensions.NumberToDuration;
using Xunit;

namespace UnitsNet.Tests
{    
    public class NumberToDurationExtensionsTests
    {
        [Fact]
        public void NumberToDaysTest() =>
            Assert.Equal(Duration.FromDays(2), 2.Days());

        [Fact]
        public void NumberToHoursTest() =>
            Assert.Equal(Duration.FromHours(2), 2.Hours());

        [Fact]
        public void NumberToMicrosecondsTest() =>
            Assert.Equal(Duration.FromMicroseconds(2), 2.Microseconds());

        [Fact]
        public void NumberToMillisecondsTest() =>
            Assert.Equal(Duration.FromMilliseconds(2), 2.Milliseconds());

        [Fact]
        public void NumberToMinutesTest() =>
            Assert.Equal(Duration.FromMinutes(2), 2.Minutes());

        [Fact]
        public void NumberToMonths30mTest() =>
            Assert.Equal(Duration.FromMonths30m(2), 2.Months30m());

        [Fact]
        public void NumberToNanosecondsTest() =>
            Assert.Equal(Duration.FromNanoseconds(2), 2.Nanoseconds());

        [Fact]
        public void NumberToSecondsTest() =>
            Assert.Equal(Duration.FromSeconds(2), 2.Seconds());

        [Fact]
        public void NumberToWeeksTest() =>
            Assert.Equal(Duration.FromWeeks(2), 2.Weeks());

        [Fact]
        public void NumberToYears365mTest() =>
            Assert.Equal(Duration.FromYears365m(2), 2.Years365m());

    }
}
