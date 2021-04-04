using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Common { 
    public  interface IHasDomainEvent {
        public List<DomainEvent> DomainEvents { get; set; }
    }

}