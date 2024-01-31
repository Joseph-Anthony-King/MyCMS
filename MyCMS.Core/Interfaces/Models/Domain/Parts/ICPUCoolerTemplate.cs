using MyCMS.Core.Enums;

namespace MyCMS.Core.Interfaces.Models.Domain.Parts
{
    internal interface ICPUCoolerTemplate : IPart, ICooler
    {
        CPUCoolerType CPUCoolerType { get; set; }
        string CPUSocketCompatability { get; set; }
        string HeatSinkMaterial { get; set; }
        string OrientationToHeatSink { get; set; }
        string MaxCPUCoolerHeight { get; set; }
    }
}
