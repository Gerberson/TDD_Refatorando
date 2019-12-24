using System;
using Flunt.Notifications;

namespace Domain.Entities
{
    public class Entity : Notifiable
    {
        public Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}