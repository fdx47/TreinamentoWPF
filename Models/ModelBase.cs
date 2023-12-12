using System.ComponentModel.DataAnnotations;

namespace TreinamentoWPF.Models
{
    public class ModelBase
    {
        [Key]
        public int Id { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Excluido { get; set; }
    }
}
