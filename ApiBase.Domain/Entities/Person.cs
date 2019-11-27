using System;

namespace ApiBase.Domain.Entities
{
    public class Person : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photo { get; set; }
        public DateTime Birtdate { get; set; }
        public string WhatsAppNumber { get; set; }
    }
}