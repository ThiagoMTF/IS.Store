using IS.Store.Domain.Entities;
using IS.Store.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace IS.Store.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<ISStoreDataContextEF>
    {
        protected override void Seed(ISStoreDataContextEF context)
        {
            context.Usuarios.Add(new Usuario()
            {
                Nome = "Thiago Muniz",
                Email = "thiagomuniz_infsys@outlook.com",
                Senha = "123456".Encrypt()
            });
            context.SaveChanges();
        }
    }
}
