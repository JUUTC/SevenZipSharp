using System;
using System.Collections.Generic;
using System.Text;

namespace SevenZip
{


    /// <summary>
    /// Represents information about a stream.
    /// </summary>
    [Serializable]
    public class StreamInfo
    {
        /// <summary>
        /// Gets or sets the index of the stream.
        /// </summary>
        /// <value>The index of the stream.</value>
        public long Index { get; set; }

        /// <summary>
        /// Gets or sets the file path of the stream.
        /// </summary>
        /// <value>The file path of the stream.</value>
        public string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the relative file path of the stream.
        /// </summary>
        /// <value>The relative file path of the stream.</value>
        public string RelativeFilePath { get; set; }

        /// <summary>
        /// Gets or sets the size of the file.
        /// </summary>
        /// <value>The size of the file.</value>
        public long FileSize { get; set; }
    }
}
