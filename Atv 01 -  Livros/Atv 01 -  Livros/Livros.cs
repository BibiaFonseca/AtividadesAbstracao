namespace Atv_01____Livros
{
    internal class Livros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Ano { get; set; }

        /*É necessário um método construtor para acessar as propriedades*/

        public Livros(string titulo, string autor, string editora, int ano)
        {
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
            Ano = ano;

        }
    }
}
