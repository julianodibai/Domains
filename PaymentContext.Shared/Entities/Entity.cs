using System;

namespace PaymentContext.Shared.Entities
{
    public abstract class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();//.ToString().Replace("-","").Substring(0,10);
        }

        public Guid Id { get; private set; }


    }
}