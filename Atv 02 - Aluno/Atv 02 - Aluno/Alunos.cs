namespace Atv_02___Aluno
{
    internal class Alunos
    {
        public int RM { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string Email { get; set; }

        public Alunos(int rm, string nome, string email, DateTime nascimento)
        {
            Nascimento = nascimento;
            RM = rm;
            Nome = nome;
            Email = email;

        }
    }
}
