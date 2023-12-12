using System.ComponentModel.DataAnnotations.Schema;

namespace TreinamentoWPF.Models
{
    public class Cliente : ModelBase
    {
        [Column(TypeName = ("varchar(100)"))]
        public string Nome { get; set; }
        [Column(TypeName = ("varchar(30)"))]
        public string? Telefone { get; set; }
        [Column(TypeName = ("varchar(30)"))]
        public string Registro { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
