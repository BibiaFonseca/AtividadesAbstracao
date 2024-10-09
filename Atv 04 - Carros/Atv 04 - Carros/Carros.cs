namespace Atv_04___Carros
{
    internal class Carros
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Velocidade { get; set; }

        public Carros(string marca, string modelo, string velocidade)
        {
            Marca = marca;
            Modelo = modelo;
            Velocidade = velocidade;
        }
        public void Acelerar()
        {
            Console.WriteLine("O carro " + Modelo + " da marca " + Marca + " acelerou em 3s");
        }

        public void Desacelerar()
        {
            Console.WriteLine("O carro " + Modelo + " da marca " + Marca + " desacelerou em 2s");
        }

    }
}
