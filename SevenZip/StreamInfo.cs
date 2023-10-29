using System;
using System.Collections.Generic;
using System.Text;

namespace SevenZip
{
    public class StreamInfo
    {
        public int Index { get; set; }
        public string FilePath { get; set; }
        public string RelativeFilePath { get; set; }
        public long FileSize { get; set; }
    }
}
