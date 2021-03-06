// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EncodeCompletedEventArgs.cs" company="HandBrake Project (https://handbrake.fr)">
//   This file is part of the HandBrake source code - It may be used under the terms of the GNU General Public License.
// </copyright>
// <summary>
//   Defines the EncodeCompletedEventArgs type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace HandBrake.Interop.Interop.Interfaces.EventArgs
{
    using System;

    /// <summary>
    /// Encode Completed Event Args
    /// </summary>
    public class EncodeCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EncodeCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="error">
        /// The error.
        /// </param>
        public EncodeCompletedEventArgs(int error)
        {
            this.Error = error;
        }

        /// <summary>
        /// Gets a value indicating whether an error occurred during the encode.
        /// </summary>
        public int Error { get; private set; }
    }
}
