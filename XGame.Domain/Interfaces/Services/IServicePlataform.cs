﻿using XGame.Domain.Arguments.Plataform;

namespace XGame.Domain.Interfaces.Services
{
    public interface IServicePlataform
    {        
        AddPlataformResponse Add(AddPlataformRequest request);
    }
}
