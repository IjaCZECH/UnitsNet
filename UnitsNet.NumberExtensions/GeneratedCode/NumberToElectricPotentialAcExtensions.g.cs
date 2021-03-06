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

namespace UnitsNet.NumberExtensions.NumberToElectricPotentialAc
{
    /// <summary>
    /// A number to ElectricPotentialAc Extensions
    /// </summary>
    public static class NumberToElectricPotentialAcExtensions
    {
        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc KilovoltsAc<T>(this T value) =>
            ElectricPotentialAc.FromKilovoltsAc(Convert.ToDecimal(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc MegavoltsAc<T>(this T value) =>
            ElectricPotentialAc.FromMegavoltsAc(Convert.ToDecimal(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc MicrovoltsAc<T>(this T value) =>
            ElectricPotentialAc.FromMicrovoltsAc(Convert.ToDecimal(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc MillivoltsAc<T>(this T value) =>
            ElectricPotentialAc.FromMillivoltsAc(Convert.ToDecimal(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(UnitsNet.QuantityValue)" />
        public static ElectricPotentialAc VoltsAc<T>(this T value) =>
            ElectricPotentialAc.FromVoltsAc(Convert.ToDecimal(value));

    }
}
