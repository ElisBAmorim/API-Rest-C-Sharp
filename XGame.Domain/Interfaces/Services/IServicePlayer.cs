using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        AddPlayerResponse Add(AddPlayerRequest request);
    }
}
