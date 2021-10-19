using System;

namespace Financeasy.Business.Core
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        public DateTime Created { get; protected set; }
        public DateTime? Updated { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }

        public void SetLastUpdate()
        {
            Updated = DateTime.Now;
        }
    }
}