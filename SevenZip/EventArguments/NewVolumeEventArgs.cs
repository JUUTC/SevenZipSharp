using System;

namespace SevenZip.EventArguments
{
    /// <summary>
    /// Event arguments for a new volume.
    /// </summary>
    public class NewVolumeEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the index of the volume.
        /// </summary>
        public readonly int VolumeIndex;

        /// <summary>
        /// Gets the proposed name of the volume.
        /// </summary>
        public readonly string VolumeProposedName;

        /// <summary>
        /// Gets or sets the source request.
        /// </summary>
        public Object SourceRequest;

        /// <summary>
        /// Initializes a new instance of the NewVolumeEventArgs class.
        /// </summary>
        /// <param name="volumeIndex">The index of the volume.</param>
        /// <param name="volumeProposedName">The proposed name of the volume.</param>
        /// <param name="sourceRequest">The source request.</param>
        public NewVolumeEventArgs(int volumeIndex, string volumeProposedName, object sourceRequest)
        {
            this.VolumeIndex = volumeIndex;
            this.VolumeProposedName = volumeProposedName;
            this.SourceRequest = sourceRequest;
        }
    }
}