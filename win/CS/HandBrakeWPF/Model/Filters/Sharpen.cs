// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Sharpen.cs" company="HandBrake Project (https://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the Sharpen type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrakeWPF.Model.Filters
{
    using HandBrake.Interop.Attributes;

    /// <summary>
    /// The Sharpen.
    /// </summary>
    public enum Sharpen
    {
        [ShortName("off")]
        Off,

        [ShortName("unsharp")]
        UnSharp,

        [ShortName("lapsharp")]
        LapSharp
    }
}
