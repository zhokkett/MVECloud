using System;
using System.Collections.Generic;

namespace MVECloud.Domain.Common {
    public abstract class DomainEvent {
        protected DomainEvent() {
            DateOcurred = DateTimeOffset.UtcNow;
        }

        public bool IsPublished { get; set; }

        public DateTimeOffset DateOcurred { get; protected set; } = DateTime.UtcNow;
    }
}