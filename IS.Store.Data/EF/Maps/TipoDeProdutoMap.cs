using IS.Store.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace IS.Store.Data.EF.Maps
{
    public class TipoDeProdutoMap:EntityTypeConfiguration<TipoDeProduto>
    {
        public TipoDeProdutoMap()
        {
            //table
            ToTable(nameof(TipoDeProduto));

            //pk
            HasKey(pk => pk.Id);

            //column
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.DataCadastro);
        }
        
    }
}
