using IS.Store.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace IS.Store.Data.EF.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {

        public ProdutoMap()
        {
            //Tabela
            ToTable(nameof(Produto));

            //PK
            HasKey(pk => pk.Id);

            //Coluna
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Preco)
                .HasColumnType("money");

            Property(c => c.Qtde)
                .HasColumnName("Quantidade");

            Property(c => c.TipoDeProdutoId);

            Property(c => c.DataCadastro);

            //Relacionamento
            HasRequired(prod => prod.TipoDeProduto)
                .WithMany(tipo => tipo.Produtos)
                .HasForeignKey(fk => fk.TipoDeProdutoId);
        }
        
    }
}
