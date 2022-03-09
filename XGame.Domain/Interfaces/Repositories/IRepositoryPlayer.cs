using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;

namespace XGame.Domain.Interfaces.Repositories
{
    public interface IRepositoryPlayer
    {
        AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request);
        Guid Add(Player player);
    }
}
