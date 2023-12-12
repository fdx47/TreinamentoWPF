namespace TreinamentoWPF.Models
{
    public class Categoria : ModelBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}
