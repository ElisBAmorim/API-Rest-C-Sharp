using XGame.Domain.Interfaces.Arguments;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerResponse : IResponse
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}
