using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreBusiness.Entidades;
using System.Threading.Tasks;

namespace CasosDeUso.Interface
{
    public interface IAdicionarObservacaoUseCase
    {
        Task ExecutaAsync(Observacao observacao);
    }
}
