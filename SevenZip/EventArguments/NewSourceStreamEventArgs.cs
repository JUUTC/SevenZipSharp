using System;

namespace SevenZip.EventArguments
{
    /// <summary>
    /// Provides data for the NewSourceStream event.
    /// </summary>
    public class NewSourceStreamEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the index of the stream.
        /// </summary>
        public readonly long StreamIndex;

        /// <summary>
        /// Gets or sets the source request object.
        /// </summary>
        public Object SourceRequest;

        /// <summary>
        /// Initializes a new instance of the NewSourceStreamEventArgs class.
        /// </summary>
        /// <param name="streamIndex">The index of the stream.</param>
        public NewSourceStreamEventArgs(long streamIndex)
        {
            this.StreamIndex = streamIndex;
        }
    }
}