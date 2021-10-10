using DevIo.Business.Models.Fornecedores;
using System.Data.Entity.ModelConfiguration;

namespace DevIo.Infra.Data.Mappings
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            HasKey(e => e.Id);

            Property(e => e.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(e => e.Numero)
                .IsRequired()
                .HasMaxLength(5);

            Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            //Property(e => e.Complemento)
                //.HasMaxLength(100);

            Property(e => e.Bairro)
                .IsRequired();
            //.HasMaxLength(100);

            Property(e => e.Cidade)
                .IsRequired();
                //.HasMaxLength(100);

            Property(e => e.Estado)
                .IsRequired()
                .HasMaxLength(2)
                .IsFixedLength();

            ToTable("Endrecos");
        }
    }
}
