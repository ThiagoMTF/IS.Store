using IS.Store.Domain.Contracts.Repositories;
using IS.Store.Domain.Entities;

namespace IS.Store.Data.EF.Repositories
{
    public class TipoDeProdutoRepositoryEF : RepositoryEF<TipoDeProduto>, ITipoDeProdutoRepository
    {
        public TipoDeProdutoRepositoryEF(ISStoreDataContextEF ctx) : base(ctx)
        {}
    }
}
