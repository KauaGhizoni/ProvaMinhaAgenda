using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;

namespace CasosDeUso
{
    public class AdicionarObservacaoUseCase : IAdicionarObservacaoUseCase
    {
        private readonly IRepositorioDeObservacoes _observacaoRepository;

        public AdicionarObservacaoUseCase(IRepositorioDeObservacoes observacaoRepository)
        {
            _observacaoRepository = observacaoRepository;
        }

        public async Task ExecutaAsync(Observacao observacao)
        {
            await _observacaoRepository.AdicionarObservacao(observacao);
        }
    }
}
