using MyCMS.Core.Enums.CPU;

namespace MyCMS.Core.Interfaces.Models.Domain.Parts
{
    internal interface IMotherboardTemplate : IPart
    {
        string FormFactor { get; set; }
        CPUSocketType CPUSocketType { get; set; }
        string CPUSocketTypeDescription { get; }
        string CPUType { get; set; }
        string ChipSet { get; set; }
        string NumberOfMemorySlots { get; set; }
        string MemoryStandard { get; set; }
        string MaximumMemorySupported { get; set; }
        string ChannelSupported { get; set; }
        string ECCSupported { get; set; }
        string BufferSupported { get; set; }
        string AudioChipset { get; set; }
        string AudioChannels { get; set; }
        string RearPanelPorts { get; set; }
        string OtherConnectors { get; set; }
    }
}
