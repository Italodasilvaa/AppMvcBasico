using System;

namespace AppMvcBasico.Models
{
    public class Produto : Entity
    {
        public Guid FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public string Nome { get; set; }
        public string Descriacao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
