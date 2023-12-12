namespace TreinamentoWPF.Models
{
    public class Orcamento : ModelBase
    {
        public Cliente Cliente { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
