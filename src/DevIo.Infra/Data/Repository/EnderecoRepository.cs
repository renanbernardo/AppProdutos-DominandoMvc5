using System;
using System.Threading.Tasks;
using DevIo.Business.Models.Fornecedores;

namespace DevIo.Infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            // O Fornecedor e o Endereço possuem o mesmo ID
            return await ObterPorId(fornecedorId);
        }
    }
}
