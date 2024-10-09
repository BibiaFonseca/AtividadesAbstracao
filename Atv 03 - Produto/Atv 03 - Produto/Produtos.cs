namespace Atv_03___Produto
{
    internal class Produtos
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        /*É necessário um método construtor para acessar as propriedades*/

        public Produtos(int codigo, string nome, double preco, int estoque)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;

        }
        public void ValorEstoque()
        {
            Console.WriteLine("O produto " + Nome + " tem " + Estoque + " itens");
        }
    }
}
