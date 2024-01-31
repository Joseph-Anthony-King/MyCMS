namespace MyCMS.Core.Interfaces.Models.Domain.Parts
{
    internal interface IMemoryTemplate : IPart
    {
        int Capacity { get; set; }
        int SticksPerKit { get; set; }
        int TotalCapacity { get; set; }
        string DisplayedCapacity { get; }
        string Speed { get; set; }
        int CASLatency { get; set; }
        int TRCD { get; set; }
        int TRP { get; set; }
        int TRAS { get; set; }
        string Timing { get; }
        string Voltage { get; set; }
        string MultiChannelKit { get; set; }
        string BiosProfile { get; set; }
    }
}
