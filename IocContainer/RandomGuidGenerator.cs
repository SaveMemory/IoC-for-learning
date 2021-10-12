using System;

namespace IocContainer
{
    public class RandomGuidGenerator : IRandomGuidGenerator
    {
        public Guid RandomGuid { get; set; } = Guid.NewGuid();
    }
}
