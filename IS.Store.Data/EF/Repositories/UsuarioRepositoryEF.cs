using IS.Store.Domain.Contracts.Repositories;
using IS.Store.Domain.Entities;
using System.Linq;

namespace IS.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(ISStoreDataContextEF ctx) : base(ctx)
        {
        }

        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u=>u.Email.ToLower() == email.ToLower());
        }
    }
}
