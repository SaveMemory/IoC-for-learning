using System;

namespace IocContainer
{
    interface IRandomGuidGenerator
    {
        Guid RandomGuid { get; set; }
    }
}
