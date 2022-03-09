using XGame.Domain.Interfaces.Arguments;

namespace XGame.Domain.Arguments.Plataform
{
    public class AddPlataformRequest : IRequest
    {
        public string Name { get; set; }
    }
}
