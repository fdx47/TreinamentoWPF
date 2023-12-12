using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TreinamentoWPF.Models
{
    public class Produto : ModelBase
    {
        [Column(TypeName = ("varchar(80)"))]
        [Required]
        public string Nome { get; set; }
        [Column(TypeName = ("varchar(80)"))]
        public string? Descricao { get; set; }
        [Column(TypeName = ("decimal(8,2)"))]
        public decimal Preco { get; set; }
        [Column(TypeName = ("decimal(8,2)"))]
        public decimal? Custo { get; set; }
        [Column(TypeName = ("varchar(10)"))]
        public string Apresentacao { get; set; } = "UN";
        [Column(TypeName = ("mediumblob"))]
        public byte[]? Imagem { get; set; }
    }
}
