using Atv_02___Aluno;

Alunos aluno1 = new Alunos(2021, "Natalia", "nataliabuzaranho@gmail.com", new DateTime(2007, 10, 26));
Console.WriteLine("O RM do aluno é: " + aluno1.RM + "\nO nome do aluno é: " + aluno1.Nome + "\nO email do aluno é: " + aluno1.Email + "\n E seu nascimento foi em: " + aluno1.Nascimento);

Alunos aluno2 = new Alunos(1994, "Maria Luiza", "mariamoraes@gmail.com", new DateTime(2007, 08, 13));
Console.WriteLine("\nO RM do aluno é: " + aluno2.RM + "\nO nome do aluno é: " + aluno2.Nome + "\nO email do aluno é: " + aluno2.Email + "\n E seu nascimento foi em: " + aluno2.Nascimento);

Alunos aluno3 = new Alunos(2014, "Larissa", "larissasantana@gmail.com", new DateTime(2007, 07, 03));
Console.WriteLine("\nO RM do aluno é: " + aluno3.RM + "\nO nome do aluno é: " + aluno3.Nome + "\nO email do aluno é: " + aluno3.Email + "\n E seu nascimento foi em: " + aluno3.Nascimento);