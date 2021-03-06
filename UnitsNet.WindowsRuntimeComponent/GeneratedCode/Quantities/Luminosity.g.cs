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
using JetBrains.Annotations;
using UnitsNet.Units;
using UnitsNet.InternalHelpers;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     Luminosity is an absolute measure of radiated electromagnetic power (light), the radiant power emitted by a light-emitting object.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Luminosity
    /// </remarks>
    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
    public sealed partial class Luminosity : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly decimal _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LuminosityUnit? _unit;

        static Luminosity()
        {
            BaseDimensions = new BaseDimensions(2, 1, -3, 0, 0, 0, 0);
            Info = new QuantityInfo(QuantityType.Luminosity, Units.Cast<Enum>().ToArray(), BaseUnit, Zero, BaseDimensions);
        }

        /// <summary>
        ///     Creates the quantity with a value of 0 in the base unit Watt.
        /// </summary>
        /// <remarks>
        ///     Windows Runtime Component requires a default constructor.
        /// </remarks>
        public Luminosity()
        {
            _value = 0;
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        private Luminosity(decimal value, LuminosityUnit unit)
        {
            if(unit == LuminosityUnit.Undefined)
              throw new ArgumentException("The quantity can not be created with an undefined unit.", nameof(unit));

            _value = value;
            _unit = unit;
        }

        #region Static Properties

        /// <summary>
        ///     Information about the quantity type, such as unit values and names.
        /// </summary>
        internal static QuantityInfo Info { get; }

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions { get; }

        /// <summary>
        ///     The base unit of Luminosity, which is Watt. All conversions go via this value.
        /// </summary>
        public static LuminosityUnit BaseUnit { get; } = LuminosityUnit.Watt;

        /// <summary>
        /// Represents the largest possible value of Luminosity
        /// </summary>
        public static Luminosity MaxValue { get; } = new Luminosity(decimal.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Luminosity
        /// </summary>
        public static Luminosity MinValue { get; } = new Luminosity(decimal.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType { get; } = QuantityType.Luminosity;

        /// <summary>
        ///     All units of measurement for the Luminosity quantity.
        /// </summary>
        public static LuminosityUnit[] Units { get; } = Enum.GetValues(typeof(LuminosityUnit)).Cast<LuminosityUnit>().Except(new LuminosityUnit[]{ LuminosityUnit.Undefined }).ToArray();

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Watt.
        /// </summary>
        public static Luminosity Zero { get; } = new Luminosity(0, BaseUnit);

        #endregion

        #region Properties

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public decimal Value => Convert.ToDecimal(_value);

        /// <inheritdoc cref="IQuantity.Unit"/>
        object IQuantity.Unit => Unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public LuminosityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        internal QuantityInfo QuantityInfo => Info;

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Luminosity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Luminosity.BaseDimensions;

        #endregion

        #region Conversion Properties

        /// <summary>
        ///     Get Luminosity in Decawatts.
        /// </summary>
        public decimal Decawatts => As(LuminosityUnit.Decawatt);

        /// <summary>
        ///     Get Luminosity in Deciwatts.
        /// </summary>
        public decimal Deciwatts => As(LuminosityUnit.Deciwatt);

        /// <summary>
        ///     Get Luminosity in Femtowatts.
        /// </summary>
        public decimal Femtowatts => As(LuminosityUnit.Femtowatt);

        /// <summary>
        ///     Get Luminosity in Gigawatts.
        /// </summary>
        public decimal Gigawatts => As(LuminosityUnit.Gigawatt);

        /// <summary>
        ///     Get Luminosity in Kilowatts.
        /// </summary>
        public decimal Kilowatts => As(LuminosityUnit.Kilowatt);

        /// <summary>
        ///     Get Luminosity in Megawatts.
        /// </summary>
        public decimal Megawatts => As(LuminosityUnit.Megawatt);

        /// <summary>
        ///     Get Luminosity in Microwatts.
        /// </summary>
        public decimal Microwatts => As(LuminosityUnit.Microwatt);

        /// <summary>
        ///     Get Luminosity in Milliwatts.
        /// </summary>
        public decimal Milliwatts => As(LuminosityUnit.Milliwatt);

        /// <summary>
        ///     Get Luminosity in Nanowatts.
        /// </summary>
        public decimal Nanowatts => As(LuminosityUnit.Nanowatt);

        /// <summary>
        ///     Get Luminosity in Petawatts.
        /// </summary>
        public decimal Petawatts => As(LuminosityUnit.Petawatt);

        /// <summary>
        ///     Get Luminosity in Picowatts.
        /// </summary>
        public decimal Picowatts => As(LuminosityUnit.Picowatt);

        /// <summary>
        ///     Get Luminosity in SolarLuminosities.
        /// </summary>
        public decimal SolarLuminosities => As(LuminosityUnit.SolarLuminosity);

        /// <summary>
        ///     Get Luminosity in Terawatts.
        /// </summary>
        public decimal Terawatts => As(LuminosityUnit.Terawatt);

        /// <summary>
        ///     Get Luminosity in Watts.
        /// </summary>
        public decimal Watts => As(LuminosityUnit.Watt);

        #endregion

        #region Static Methods

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        public static string GetAbbreviation(LuminosityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static string GetAbbreviation(LuminosityUnit unit, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit, provider);
        }

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Luminosity from Decawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromDecawatts(decimal decawatts)
        {
            decimal value = (decimal) decawatts;
            return new Luminosity(value, LuminosityUnit.Decawatt);
        }
        /// <summary>
        ///     Get Luminosity from Deciwatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromDeciwatts(decimal deciwatts)
        {
            decimal value = (decimal) deciwatts;
            return new Luminosity(value, LuminosityUnit.Deciwatt);
        }
        /// <summary>
        ///     Get Luminosity from Femtowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromFemtowatts(decimal femtowatts)
        {
            decimal value = (decimal) femtowatts;
            return new Luminosity(value, LuminosityUnit.Femtowatt);
        }
        /// <summary>
        ///     Get Luminosity from Gigawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromGigawatts(decimal gigawatts)
        {
            decimal value = (decimal) gigawatts;
            return new Luminosity(value, LuminosityUnit.Gigawatt);
        }
        /// <summary>
        ///     Get Luminosity from Kilowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromKilowatts(decimal kilowatts)
        {
            decimal value = (decimal) kilowatts;
            return new Luminosity(value, LuminosityUnit.Kilowatt);
        }
        /// <summary>
        ///     Get Luminosity from Megawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromMegawatts(decimal megawatts)
        {
            decimal value = (decimal) megawatts;
            return new Luminosity(value, LuminosityUnit.Megawatt);
        }
        /// <summary>
        ///     Get Luminosity from Microwatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromMicrowatts(decimal microwatts)
        {
            decimal value = (decimal) microwatts;
            return new Luminosity(value, LuminosityUnit.Microwatt);
        }
        /// <summary>
        ///     Get Luminosity from Milliwatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromMilliwatts(decimal milliwatts)
        {
            decimal value = (decimal) milliwatts;
            return new Luminosity(value, LuminosityUnit.Milliwatt);
        }
        /// <summary>
        ///     Get Luminosity from Nanowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromNanowatts(decimal nanowatts)
        {
            decimal value = (decimal) nanowatts;
            return new Luminosity(value, LuminosityUnit.Nanowatt);
        }
        /// <summary>
        ///     Get Luminosity from Petawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromPetawatts(decimal petawatts)
        {
            decimal value = (decimal) petawatts;
            return new Luminosity(value, LuminosityUnit.Petawatt);
        }
        /// <summary>
        ///     Get Luminosity from Picowatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromPicowatts(decimal picowatts)
        {
            decimal value = (decimal) picowatts;
            return new Luminosity(value, LuminosityUnit.Picowatt);
        }
        /// <summary>
        ///     Get Luminosity from SolarLuminosities.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromSolarLuminosities(decimal solarluminosities)
        {
            decimal value = (decimal) solarluminosities;
            return new Luminosity(value, LuminosityUnit.SolarLuminosity);
        }
        /// <summary>
        ///     Get Luminosity from Terawatts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromTerawatts(decimal terawatts)
        {
            decimal value = (decimal) terawatts;
            return new Luminosity(value, LuminosityUnit.Terawatt);
        }
        /// <summary>
        ///     Get Luminosity from Watts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Luminosity FromWatts(decimal watts)
        {
            decimal value = (decimal) watts;
            return new Luminosity(value, LuminosityUnit.Watt);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LuminosityUnit" /> to <see cref="Luminosity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Luminosity unit value.</returns>
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Luminosity From(decimal value, LuminosityUnit fromUnit)
        {
            return new Luminosity((decimal)value, fromUnit);
        }

        #endregion

        #region Static Parse Methods

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Luminosity Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static Luminosity Parse(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.Parse<Luminosity, LuminosityUnit>(
                str,
                provider,
                From);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Luminosity result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] string cultureName, out Luminosity result)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return QuantityParser.Default.TryParse<Luminosity, LuminosityUnit>(
                str,
                provider,
                From,
                out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static LuminosityUnit ParseUnit(string str)
        {
            return ParseUnit(str, null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static LuminosityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.Parse<LuminosityUnit>(str, provider);
        }

        public static bool TryParseUnit(string str, out LuminosityUnit unit)
        {
            return TryParseUnit(str, null, out unit);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="unit">The parsed unit if successful.</param>
        /// <returns>True if successful, otherwise false.</returns>
        /// <example>
        ///     Length.TryParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public static bool TryParseUnit(string str, [CanBeNull] string cultureName, out LuminosityUnit unit)
        {
            IFormatProvider provider = GetFormatProviderFromCultureName(cultureName);
            return UnitParser.Default.TryParse<LuminosityUnit>(str, provider, out unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Luminosity objLuminosity)) throw new ArgumentException("Expected type Luminosity.", nameof(obj));

            return CompareTo(objLuminosity);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        internal int CompareTo(Luminosity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Windows.Foundation.Metadata.DefaultOverload]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Luminosity objLuminosity))
                return false;

            return Equals(objLuminosity);
        }

        public bool Equals(Luminosity other)
        {
            return _value.Equals(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Luminosity within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Luminosity other, decimal tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            decimal thisValue = (decimal)this.Value;
            decimal otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Luminosity.</returns>
        public override int GetHashCode()
        {
            return new { QuantityType, Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion Methods

        decimal IQuantity.As(object unit) => As((LuminosityUnit)unit);

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public decimal As(LuminosityUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDecimal(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDecimal(converted);
        }

        /// <summary>
        ///     Converts this Luminosity to another Luminosity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Luminosity with the specified unit.</returns>
        public Luminosity ToUnit(LuminosityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Luminosity(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private decimal AsBaseUnit()
        {
            switch(Unit)
            {
                case LuminosityUnit.Decawatt: return (_value) * 1e1m;
                case LuminosityUnit.Deciwatt: return (_value) * 1e-1m;
                case LuminosityUnit.Femtowatt: return (_value) * 1e-15m;
                case LuminosityUnit.Gigawatt: return (_value) * 1e9m;
                case LuminosityUnit.Kilowatt: return (_value) * 1e3m;
                case LuminosityUnit.Megawatt: return (_value) * 1e6m;
                case LuminosityUnit.Microwatt: return (_value) * 1e-6m;
                case LuminosityUnit.Milliwatt: return (_value) * 1e-3m;
                case LuminosityUnit.Nanowatt: return (_value) * 1e-9m;
                case LuminosityUnit.Petawatt: return (_value) * 1e15m;
                case LuminosityUnit.Picowatt: return (_value) * 1e-12m;
                case LuminosityUnit.SolarLuminosity: return _value * 3.846e26m;
                case LuminosityUnit.Terawatt: return (_value) * 1e12m;
                case LuminosityUnit.Watt: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private decimal AsBaseNumericType(LuminosityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case LuminosityUnit.Decawatt: return (baseUnitValue) / 1e1m;
                case LuminosityUnit.Deciwatt: return (baseUnitValue) / 1e-1m;
                case LuminosityUnit.Femtowatt: return (baseUnitValue) / 1e-15m;
                case LuminosityUnit.Gigawatt: return (baseUnitValue) / 1e9m;
                case LuminosityUnit.Kilowatt: return (baseUnitValue) / 1e3m;
                case LuminosityUnit.Megawatt: return (baseUnitValue) / 1e6m;
                case LuminosityUnit.Microwatt: return (baseUnitValue) / 1e-6m;
                case LuminosityUnit.Milliwatt: return (baseUnitValue) / 1e-3m;
                case LuminosityUnit.Nanowatt: return (baseUnitValue) / 1e-9m;
                case LuminosityUnit.Petawatt: return (baseUnitValue) / 1e15m;
                case LuminosityUnit.Picowatt: return (baseUnitValue) / 1e-12m;
                case LuminosityUnit.SolarLuminosity: return baseUnitValue / 3.846e26m;
                case LuminosityUnit.Terawatt: return (baseUnitValue) / 1e12m;
                case LuminosityUnit.Watt: return baseUnitValue;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(null);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName)
        {
            var provider = cultureName;
            return ToString(provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString(string cultureName, int significantDigitsAfterRadix)
        {
            var provider = cultureName;
            var value = Convert.ToDecimal(Value);
            var format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implicitly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="GlobalConfiguration.DefaultCulture" /> if null.</param>
        public string ToString([CanBeNull] string cultureName, [NotNull] string format, [NotNull] params object[] args)
        {
            var provider = GetFormatProviderFromCultureName(cultureName);
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? GlobalConfiguration.DefaultCulture;

            var value = Convert.ToDecimal(Value);
            var formatArgs = UnitFormatter.GetFormatArgs(Unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion

        private static IFormatProvider GetFormatProviderFromCultureName([CanBeNull] string cultureName)
        {
            return cultureName != null ? new CultureInfo(cultureName) : (IFormatProvider)null;
        }
    }
}
