using MyCMS.Core.Enums;

namespace MyCMS.Core.Interfaces.Models.Domain
{
    internal interface ICommercial : IDomainEntity
    {
        Brand Brand { get; set; }
        List<IAddress> Addresses { get; set; }
        string Url { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
    }
}
