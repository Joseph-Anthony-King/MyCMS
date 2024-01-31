namespace MyCMS.Core.Interfaces.Models.Domain
{
    internal interface IPrivateIndividual : IDomainEntity
    {
        List<IAddress> Addresses { get; set; }
        string Phone { get; set; }
        string Cell { get; set; }
        string Email { get; set; }
    }
}
