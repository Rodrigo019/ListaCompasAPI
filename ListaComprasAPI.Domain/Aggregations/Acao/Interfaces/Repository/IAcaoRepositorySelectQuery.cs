﻿using ListaComprasAPI.Domain.Aggregations.Acao.Models;
using ListaComprasAPI.Domain.Interfaces.Respositories;

namespace ListaComprasAPI.Domain.Aggregations.Acao.Interfaces.Repository
{
    public interface IAcaoServiceSelectQuery :
        IRepositorySelectQuery<AcaoModel,AcaoArgs>
    {
    }
}
