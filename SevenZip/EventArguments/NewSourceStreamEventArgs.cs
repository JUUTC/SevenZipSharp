using System;
using System.Collections.Generic;
using System.Text;

namespace SevenZip.EventArguments
{
    public class NewSourceStreamEventArgs : EventArgs
    {
        public readonly uint StreamIndex;
        public Object SourceRequest;

        public NewSourceStreamEventArgs(uint streamIndex)
        {
            this.StreamIndex = streamIndex;
        }
    }
}
