// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HandBrakeLanguagesHelper.cs" company="HandBrake Project (https://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Contains utilities for converting language codes.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.Interop
{
    using System.Collections.Generic;

    using HandBrake.Interop.Interop.HbLib;
    using HandBrake.Interop.Interop.Helpers;
    using HandBrake.Interop.Interop.Interfaces.Model;

    /// <summary>
    /// Contains utilities for converting language codes.
    /// </summary>
    public static class HandBrakeLanguagesHelper
    {
        private static IList<Language> allLanguages;

        /// <summary>
        /// Gets a list of all languages.
        /// </summary>
        public static IList<Language> AllLanguages
        {
            get
            {
                return allLanguages
                       ?? (allLanguages =
                           InteropUtilities.ToListFromIterator<iso639_lang_t, Language>(HBFunctions.lang_get_next, HandBrakeUnitConversionHelpers.NativeToLanguage));
            }
        }

        /// <summary>
        /// Gets the language object for the given code.
        /// </summary>
        /// <param name="code">The ISO-639-2 code for the language.</param>
        /// <returns>Object that describes the language.</returns>
        public static Language Get(string code)
        {
            iso639_lang_t language = InteropUtilities.ToStructureFromPtr<iso639_lang_t>(HBFunctions.lang_for_code2(code));
            return HandBrakeUnitConversionHelpers.NativeToLanguage(language);
        }
    }
}
