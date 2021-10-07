﻿using DevIo.Business.Core.Models;
using DevIo.Business.Models.Produtos;
using System.Collections.Generic;

namespace DevIo.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        //EF Relations
        public ICollection<Produto> Produtos { get; set; }
    }
}
