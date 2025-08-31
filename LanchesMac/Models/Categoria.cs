namespace LanchesMac.Models
{
    public sealed class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }
        public List<Lanche> Lanches { get; set; } = new List<Lanche>();
    }
}