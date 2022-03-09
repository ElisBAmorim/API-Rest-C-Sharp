using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Player
{
    public class AuthenticatePlayerRequest : IRequest
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
