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
            var alimento = new TipoDeProduto { Nome = "Alimento" };
            var informatica = new TipoDeProduto { Nome = "Informática" };
            var eletronico = new TipoDeProduto { Nome = "Eletrônico" };
            var higiene = new TipoDeProduto { Nome = "Higiene" };
            var limpeza = new TipoDeProduto { Nome = "Limpeza" };

            var produtos = new List<Produto>() {
                new Produto() {Nome="Picanha", Preco=79.99m, Qtde=150, TipoDeProduto = alimento },
                new Produto() {Nome="Fraldinha", Preco=59.99m, Qtde=150, TipoDeProduto = alimento},
                new Produto() {Nome="Pasta de Dente", Preco=9.99m, Qtde=200, TipoDeProduto = higiene},
                new Produto() {Nome="Desinfetante", Preco=19.99m, Qtde=250, TipoDeProduto = limpeza},
                new Produto() {Nome="Sabão em pó", Preco=20.99m, Qtde=250, TipoDeProduto = limpeza},
                new Produto() {Nome="Sabonete", Preco=1.99m, Qtde=300, TipoDeProduto = higiene},
                new Produto() {Nome="Computador", Preco=7999.99m, Qtde=50, TipoDeProduto = informatica},
                new Produto() {Nome="Telefone", Preco=35.15m, Qtde=50, TipoDeProduto = eletronico}
            };
            context.Produtos.AddRange(produtos);

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
