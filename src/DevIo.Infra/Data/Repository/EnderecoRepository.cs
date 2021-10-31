using System;
using System.Threading.Tasks;
using DevIo.Business.Models.Fornecedores;
using DevIo.Infra.Data.Context;

namespace DevIo.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {        
        public EnderecoRepository(AppProdutosContext context) : base(context) { }
     
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            // O Fornecedor e o Endereço possuem o mesmo ID
            return await ObterPorId(fornecedorId);
        }
    }
}
