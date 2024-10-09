namespace _02___Abstração
{
    /*Classe representa algo do mundo real*/
    internal class Pet
    {
        /*Atributos/propriedades*/
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }

        /*É necessário um método construtor para acessar as propriedades*/

        public Pet(string nome, string raca, int idade)
        {
            Nome = nome;
            Raca = raca;
            Idade = idade;

        }

        /*Método para alimentar*/
        public void alimentar()
        {
            Console.WriteLine($"O pet {Nome} está alimentado");
        }
    }
}
