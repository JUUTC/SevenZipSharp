using System;
using System.Collections.Generic;
using System.Text;

namespace SevenZip.EventArguments
{
    public class NewVolumeEventArgs : EventArgs
    {
        public readonly int VolumeIndex;
        public readonly string VolumeProposedName;
        public Object SourceRequest;

        public NewVolumeEventArgs(int volumeIndex, string volumeProposedName, object sourceRequest)
        {
            this.VolumeIndex = volumeIndex;
            this.VolumeProposedName = volumeProposedName;
            this.SourceRequest = sourceRequest;
        }
    }
}
