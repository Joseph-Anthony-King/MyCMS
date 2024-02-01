using System.ComponentModel;

namespace MyCMS.Core.Enums.Motherboard
{
    internal enum MotherboardChannelSupported
    {
        [Description("Dual Channel")]
        DUALCHANNEL,
        [Description("Tripple Channel")]
        TRIPPLECHANNEL,
        [Description("Quad Channel")]
        QUADCHANNEL,
    }
}
