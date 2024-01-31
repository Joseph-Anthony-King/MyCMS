using MyCMS.Core.Enums.CPU;

namespace MyCMS.Core.Interfaces.Models.Domain.Computers
{
    internal interface IBuild : IDomainEntity
    {
        int ModelID { get; set; }
        string ModelNumber { get; }
        CPUPlatform PlatForm { get; set; }
        int Wattage { get; }
        string WattageEstimate { get; }
        int Airflow { get; }
        string TotalAirflow { get; }
        int NoiseLevel { get; }
        string TotalNoiseLevel { get; }
    }
}
