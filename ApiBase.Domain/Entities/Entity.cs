using System;

namespace ApiBase.Domain.Entities
{
    public class Entity
    {
        protected Entity(){
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}