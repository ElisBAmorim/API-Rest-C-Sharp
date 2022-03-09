using System;

namespace XGame.Domain.Entities
{
    public class MyGame
    {
        public Guid Id { get; set; }
        public string Name { get; set; }    
        public GamePlataform GamePlataform { get; set; }
        public bool Desire { get; set; }
        public DateTime DateDesire { get; set; }
        public bool Exchange { get; set; }
        public bool Sell { get; set; }

    }
}
