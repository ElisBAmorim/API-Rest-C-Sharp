using System;
using XGame.Domain.Enum;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Player
    {
        public Player(Name name, Email email)
        {
            if (string.IsNullOrEmpty(email.Address))
            {
                throw new Exception("Informe um email");
            }
            if (string.IsNullOrEmpty(name.FirstName))
            {
                throw new Exception("Informe uma senha");
            }

            Name = name;
            Email = email;
        }

        public Guid Id { get; set; }
        public Name Name { get; set; }
        public Email Email { get; set; }
        public EnumStatusPlayer Status { get; set; }
        public string Password { get; set; }
    }
}
