﻿namespace MyCMS.Core.Interfaces.Models.Domain
{
    internal interface IRetailer : ICommercial
    {
        List<IStore> Locations { get; set; }
    }
}
