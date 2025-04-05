using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreBusiness.Entidades;
using System.Threading.Tasks;

namespace CasosDeUso.PluginsInterfaces
{
    public interface IRepositorioDeObservacoes
    {
        Task AdicionarObservacao(Observacao observacao);
        Task AdicionarObservacaoAsync(Observacao observacao);
    }
}
