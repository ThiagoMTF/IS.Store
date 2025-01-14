using IS.Store.Domain.Contracts.Repositories;
using IS.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace IS.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(ISStoreDataContextEF ctx) : base(ctx)
        {}

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return _ctx.Produtos.Where(p => p.Nome.Contains(contains));
        }
    }
}
