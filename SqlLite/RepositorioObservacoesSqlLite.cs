using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;
using SQLite;
namespace MinhaAgenda.Plugins.SqlLite
{
    public class RepositorioObservacaoSqlLite : IRepositorioDeObservacoes
    {
        private SQLiteAsyncConnection _database;
        public RepositorioObservacaoSqlLite()


        {

            _database = new SQLiteAsyncConnection(Constantes._databasepath);

            _database.CreateTableAsync<Observacao>().Wait();

        }

        public Task AdicionarObservacao(Observacao observacao)
        {
            return Task.FromResult(AdicionarContatoAsync(observacao));
        }

        public async Task AdicionarContatoAsync(Observacao observacao)


        {
            await _database.InsertAsync(observacao);
        }
    }


}