﻿//-----------------------------------------------------------------------
// <copyright file="Weights.cs" company="BridgeLabz Solution">
//  Copyright (c) BridgeLabz Solution. All rights reserved.
// </copyright>
// <author>Datta Dhebe</author>
//-----------------------------------------------------------------------

namespace Quantity_Measurements
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class for weights
    /// </summary>
    public class Weights
    {
        /// <summary>
        /// pre-defined value for converting Kilogram to Grams
        /// </summary>
        private const double KilogramToGrams = 1000;

        /// <summary>
        /// pre-defined value for converting Tone to Kilogram
        /// </summary>
        private const double TonneToKilograms = 1000;

        /// <summary>
        /// enum to specify measurements
        /// </summary>
        public enum Unit 
        { 
            /// <summary>
            /// for measurement of kilogram
            /// </summary>
            kilogram,

            /// <summary>
            /// for measurement of grams
            /// </summary>
            Grams,

            /// <summary>
            /// for measurement of Tone
            /// </summary>
            Tonne,

            /// <summary>
            /// for measurement of kilogram TO grams
            /// </summary>
            KilogramToGrams,

            /// <summary>
            /// for measurement of Tone To kilogram
            /// </summary>
            TonneToKilograms
        }

        /// <summary>
        /// Method to convert one volume to another
        /// </summary>
        /// <param name="unit">defines which unit used</param>
        /// <param name="weights">weights for conversion</param>
        /// <returns>returns value after calculation</returns>
        public double ConvertWeigths(Unit unit, double weights)
        {
            try
            {
                if (unit.Equals(Unit.KilogramToGrams))
                {
                    return weights * KilogramToGrams;
                }

                if (unit.Equals(Unit.TonneToKilograms))
                {
                    return weights * TonneToKilograms;
                }

                return weights;
            }
            catch (QuantityException e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidLength, e.Message);
            }
            catch (Exception e)
            {
                throw new QuantityException(QuantityException.ExceptionType.InvalidLength, e.Message);
            }
        }
    }
}
