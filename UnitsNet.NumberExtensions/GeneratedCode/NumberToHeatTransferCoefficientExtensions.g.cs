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

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToHeatTransferCoefficient
{
    /// <summary>
    /// A number to HeatTransferCoefficient Extensions
    /// </summary>
    public static class NumberToHeatTransferCoefficientExtensions
    {
        /// <inheritdoc cref="HeatTransferCoefficient.FromBtusPerSquareFootDegreeFahrenheit(UnitsNet.QuantityValue)" />
        public static HeatTransferCoefficient BtusPerSquareFootDegreeFahrenheit<T>(this T value) =>
            HeatTransferCoefficient.FromBtusPerSquareFootDegreeFahrenheit(Convert.ToDecimal(value));

        /// <inheritdoc cref="HeatTransferCoefficient.FromWattsPerSquareMeterCelsius(UnitsNet.QuantityValue)" />
        public static HeatTransferCoefficient WattsPerSquareMeterCelsius<T>(this T value) =>
            HeatTransferCoefficient.FromWattsPerSquareMeterCelsius(Convert.ToDecimal(value));

        /// <inheritdoc cref="HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(UnitsNet.QuantityValue)" />
        public static HeatTransferCoefficient WattsPerSquareMeterKelvin<T>(this T value) =>
            HeatTransferCoefficient.FromWattsPerSquareMeterKelvin(Convert.ToDecimal(value));

    }
}
