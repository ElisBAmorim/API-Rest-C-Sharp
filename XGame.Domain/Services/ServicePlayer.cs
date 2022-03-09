using System;
using XGame.Domain.Arguments.Player;
using XGame.Domain.Entities;
using XGame.Domain.Interfaces.Repositories;
using XGame.Domain.Interfaces.Services;

namespace XGame.Domain.Services
{
    public class ServicePlayer : IServicePlayer
    {
        private readonly IRepositoryPlayer _repositoryPlayer;

        public ServicePlayer(IRepositoryPlayer repositoryPlayer)
        {
            this._repositoryPlayer = repositoryPlayer;
        }

        public AddPlayerResponse Add(AddPlayerRequest request)
        {
            Player player = new Player();
            player.Name = request.Name;
            player.Status = Enum.EnumStatusPlayer.InProgress;

            Guid id = _repositoryPlayer.Add(player);
            return new AddPlayerResponse() { Id = id, message = " Operação ..." };
        }

        public AuthenticatePlayerResponse Authenticate(AuthenticatePlayerRequest request)
        {
            if (request == null)
            {
                throw new Exception("Autencitar jogadorRequest é obrigatorio");
            }
            if (string.IsNullOrEmpty(request.Email))
            {
                throw new Exception("Informe um email");
            }
            if (string.IsNullOrEmpty(request.Senha))
            {
                throw new Exception("Informe uma senha");
            }

            return _repositoryPlayer.Authenticate(request);
        }
    }
}
