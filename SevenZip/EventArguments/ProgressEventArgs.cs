using System;

namespace SevenZip
{
    /// <summary>
    /// The EventArgs class for accurate progress handling.
    /// </summary>
    public sealed class ProgressEventArgs : PercentDoneEventArgs
    {
        private object _sourceRequest;

        /// <summary>
        /// Gets or sets the source request.
        /// </summary>
        /// <value>The source request.</value>
        public object SourceRequest
        {
            get
            {
                return _sourceRequest;
            }
            /// <summary>
            /// Sets the source request.
            /// </summary>
            /// <param name = "value" > The source uncompressed stream.</param>
            set
            {
                _sourceRequest = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ProgressEventArgs class.
        /// </summary>
        /// <param name="percentDone">The percent of finished work.</param>
        /// <param name="percentDelta">The percent of work done after the previous event.</param>
        public ProgressEventArgs(byte percentDone, byte percentDelta)
            : base(percentDone)
        {
            PercentDelta = percentDelta;
        }

        /// <summary>
        /// Gets the change in done work percentage.
        /// </summary>
        /// <value>The change in done work percentage.</value>
        public byte PercentDelta { get; }
    }
}